cmake_minimum_required (VERSION 3.8)

project ("CTPInvoke.Linux")

set(CMAKE_CXX_STANDARD 17)

set(CMAKE_BUILD_TYPE "Debug")
#set(CMAKE_BUILD_TYPE "Release")
set(CMAKE_CXX_FLAGS_DEBUG "-DDEBUG -Wall -g -Wno-deprecated-declarations -Wno-parentheses")
set(CMAKE_CXX_FLAGS_RELEASE "-O3 -Wno-deprecated-declarations -Wno-parentheses")

file(GLOB_RECURSE ALL_FILES ../CTPAPI6.6.9/generated/*.cpp)
add_library (CTPInvoke SHARED ${ALL_FILES})