# DMappedInjector
A C# based implant that uses D/Invokes Manual Memory Mapping Technique to Dynamically search through a freshly mapped module (kernel32.dll, ntdll.dll etc) for the required API addresss to perfrom Process Injection

 * This has the advantage of bypassing EDR hooks that are looking through the original modules for 'suspicious' calls
 
 * Heavily leveraged code from TheWover's github - https://github.com/TheWover/DInvoke
 
 * Included XOR encrypted Shellcode to make it harder to detect by AV/EDR

 * Note: Don't forget to include/reference the D/Invoke DLL when compiling your project.
    * This will increase the detection, however other means can be employed to make the implant stealthier.
    * e.g. Play with sleep timers, include non-emulaed APIs, apply obfuscation, Patch ETW, implement Indirect Syscalls, Stage payload, inject into same process etc.


**As at October 15, 2023 this had only 5 vendors and no sandboxes flagging it**

![image](https://github.com/anans3-gh/DMappedInjector/assets/57995347/1a5ddf4e-657b-4d01-af5d-cd813bc5dd2f)

