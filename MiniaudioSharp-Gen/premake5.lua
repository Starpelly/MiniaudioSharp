outputdir = "%{cfg.buildcfg}-%{cfg.system}-%{cfg.architecture}"

workspace "miniaudio"
    architecture "x64"
    configurations { "Release" }

project "miniaudio"
    location "miniaudio"
    kind "SharedLib"
    language "C"

    targetdir ("bin/%{cfg.buildcfg}/")
    objdir ("bin-int/" .. outputdir .. "/%{prj.name}")

    files
    {
        "miniaudio/src/*.h",
        "miniaudio/src/*.c"
    }

    includedirs
    {
        "miniaudio/src"
    }