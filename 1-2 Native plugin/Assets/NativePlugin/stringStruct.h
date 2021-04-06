#ifndef STRINGSTRUCT_H
#define STRINGSTRUCT_H

#define DLL_EXPORT _declspec(dllexport)


extern "C"{
    DLLExport struct TwoStrings {
        string string1;
        string string2;
        string concatenated;
    }
}

#endif