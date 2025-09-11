import os
import subprocess
from io import TextIOWrapper

DEFINES = '''
#ifndef CTPSHARP_STDCALL
# if defined(_WIN32) || defined(__WIN32__) || defined(__CYGWIN__)
#   define CTPSHARP_STDCALL __stdcall
# else
#   define CTPSHARP_STDCALL
# endif
#endif

#ifndef CTPSHARP_EXPORT
# if defined(_WIN32) || defined(__WIN32__) || defined(__CYGWIN__)
#   if defined(STATIC_LINKED)
#     define CTPSHARP_EXPORT
#   else
#     define CTPSHARP_EXPORT __declspec(dllexport)
#   endif
# else
#   if defined(__GNUC__) && defined(GCC_HASCLASSVISIBILITY)
#     define CTPSHARP_EXPORT __attribute__ ((visibility("default")))
#   else
#     define CTPSHARP_EXPORT
#   endif
# endif
#endif

typedef unsigned char bool;
'''

baseDir = os.path.dirname(__file__)
header_file = os.path.join(baseDir, "CTPInvoke.h")
rust_file = os.path.join(baseDir, "ctp.rs")

def transform(input: str, file_out: TextIOWrapper):
    callback_lines: list[str] = []
    with open(os.path.join(baseDir, input), encoding='utf-8-sig') as file_in:
        for line in file_in:
            if line.startswith("struct"):
                callback_lines.append(line)
            elif len(callback_lines) > 0:                
                callback_lines.append(line)
                if line.startswith("};"):
                    file_out.writelines(callback_lines)
                    callback_lines.clear()                    
            elif line.startswith("CTPSHARP_EXPORT"):
                line = line.strip('\n') + ";\n"
                file_out.writelines([line])    

def generate_header():
    file_out = open(header_file, mode='w')
    file_out.writelines('#include "ThostFtdcUserApiStruct.h"')
    file_out.writelines(DEFINES)

    transform("CTPTd.cpp", file_out)
    transform("CTPMd.cpp", file_out)

    file_out.flush()
    file_out.close()

def generate_rust():
    result = subprocess.run(["bindgen", 
                             "--wrap-unsafe-ops",
                             "--no-layout-tests",
                             "--dynamic-loading", "CTPInvoke",
                             f"{header_file}", 
                             "-o", f"{rust_file}"]                             
                             )
    if result.returncode == 0:
        print("rust绑定文件生成成功")
    else:
        print(result.stderr)
    os.remove(header_file)

def run():
    generate_header()
    generate_rust()

if __name__ == "__main__":
    run()