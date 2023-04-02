cmake_minimum_required (VERSION 3.14)

project ("CTPInvoke.Linux")

set(CMAKE_CXX_STANDARD 17)

set(CMAKE_BUILD_TYPE "Debug")
#set(CMAKE_BUILD_TYPE "Release")
set(CMAKE_CXX_FLAGS_DEBUG "-DDEBUG -m64 -Wall -g -Wno-deprecated-declarations -Wno-parentheses")
set(CMAKE_CXX_FLAGS_RELEASE "-m64 -O3 -Wno-deprecated-declarations -Wno-parentheses")

get_filename_component(CTP_API_DIR "../CTPAPI6.6.9/" ABSOLUTE)
message(STATUS "CTPAPI locatin:${CTP_API_DIR}")
add_library(CTPInvoke SHARED
  ${CTP_API_DIR}/generated/CTPMd.cpp
  ${CTP_API_DIR}/generated/CTPTd.cpp
)
message(STATUS ${td_so})
target_link_libraries(CTPInvoke 
    ${CTP_API_DIR}/libthosttraderapi_se.so
    ${CTP_API_DIR}/libthostmduserapi_se.so
)