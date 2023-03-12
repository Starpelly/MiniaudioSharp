ClangSharpPInvokeGenerator `
    -c multi-file generate-file-scoped-namespaces generate-helper-types <# configuration for the generator#> `
    --file miniaudio\src\miniaudio.h <# file we want to generate bindings for #>  `
    --traverse miniaudio\src\miniaudio.h `
    -n MiniaudioSharp <# namespace of the bindings #> `
    --methodClassName Miniaudio <# class name where to put methods #> `
    --libraryPath miniaudio <# name of the DLL #> `
    -o ..\MiniaudioTest\Miniaudio <# output folder #>