ClangSharpPInvokeGenerator `
    -c multi-file generate-file-scoped-namespaces generate-helper-types <# configuration for the generator#> `
    --file miniaudio\vendor\miniaudio.h <# file we want to generate bindings for #>  `
    --traverse miniaudio\vendor\miniaudio.h `
    -n MiniaudioSharp <# namespace of the bindings #> `
    --methodClassName Miniaudio <# class name where to put methods #> `
    --libraryPath miniaudio <# name of the DLL #> `
    -o ..\Miniaudio <# output folder #>