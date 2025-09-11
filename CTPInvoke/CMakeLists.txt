cmake_minimum_required (VERSION 3.14)

project ("CTPInvoke")

set(CMAKE_CXX_STANDARD 17)

if(WIN32)
  get_filename_component(PUBLISH_DIR "../Publish/Win64.NET8/" ABSOLUTE)
else()
  get_filename_component(PUBLISH_DIR "../Publish/Linux64.NET8/" ABSOLUTE)
endif()

message("当前模式编译 ${CMAKE_BUILD_TYPE}")
if(${CMAKE_BUILD_TYPE} STREQUAL "Debug")
  message("build for debug")
  set(OUTPUT_DIRECTORY "${PUBLISH_DIR}/Debug")
else()
  message("build for release")
  set(OUTPUT_DIRECTORY "${PUBLISH_DIR}/Release")
endif()
message("output dir is: ${OUTPUT_DIRECTORY}")

get_filename_component(CTP_API_DIR "../CTPAPI/" ABSOLUTE)
get_filename_component(GEN_CODE_DIR "../generated/" ABSOLUTE)
message(STATUS "CTPAPI locatin:${CTP_API_DIR}")
add_library(CTPInvoke SHARED
  ${GEN_CODE_DIR}/CTPMd.cpp
  ${GEN_CODE_DIR}/CTPTd.cpp
)

target_link_directories(CTPInvoke PUBLIC ${CTP_API_DIR})
if(WIN32)
  target_link_libraries(CTPInvoke 
      thosttraderapi_se.lib
      thostmduserapi_se.lib
  )
else()
  target_link_libraries(CTPInvoke 
      libthosttraderapi_se.so
      libthostmduserapi_se.so
  )
endif()

add_custom_command(TARGET CTPInvoke POST_BUILD
    COMMAND ${CMAKE_COMMAND} -E copy_if_different
    $<TARGET_FILE:CTPInvoke> ${OUTPUT_DIRECTORY}
)