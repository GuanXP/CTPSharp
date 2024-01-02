cmake_minimum_required (VERSION 3.14)

project ("CTPInvoke.Linux")

set(CMAKE_CXX_STANDARD 17)

get_filename_component(PUBLISH_DIR "../Publish/Linux64.NET8/" ABSOLUTE)
if (CMAKE_BUILD_TYPE STREQUAL DEBUG)
  message("build for debug")
  set(CMAKE_CXX_FLAGS "-DDEBUG -m64 -Wall -g -Wno-deprecated-declarations -Wno-parentheses")
  set(CMAKE_LIBRARY_OUTPUT_DIRECTORY "${PUBLISH_DIR}/Debug")
else()
  message("build for release")
  set(CMAKE_CXX_FLAGS "-m64 -O3 -Wno-deprecated-declarations -Wno-parentheses")
  set(CMAKE_LIBRARY_OUTPUT_DIRECTORY "${PUBLISH_DIR}/Release")
endif()

get_filename_component(CTP_API_DIR "../CTPAPI/" ABSOLUTE)
get_filename_component(GEN_CODE_DIR "../generated/" ABSOLUTE)
message(STATUS "CTPAPI locatin:${CTP_API_DIR}")
add_library(CTPInvoke SHARED
  ${GEN_CODE_DIR}/CTPMd.cpp
  ${GEN_CODE_DIR}/CTPTd.cpp
)
message(STATUS ${td_so})
target_link_libraries(CTPInvoke 
    ${CTP_API_DIR}/libthosttraderapi_se.so
    ${CTP_API_DIR}/libthostmduserapi_se.so
)