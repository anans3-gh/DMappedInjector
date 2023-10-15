# DMappedInjector
Uses D/Invokes Manual Memory Mapping Technique to Dynamically search through a freshly mapped module (kernel32.dll, ntdll.dll etc) for the required API addresss to perfrom Process Injection

 * This has the advantage of bypassing EDR hooks that are looking through the original modules for 'suspicious' calls
 
 * https://github.com/TheWover/DInvoke
 
 * Included XOR encrypted Shellcode to make it harder to detect by AV/EDR


**As at October 15, 2023 this had only 5 vendors and no sandboxes flagging it**

![image](https://github.com/anans3-gh/DMappedInjector/assets/57995347/1a5ddf4e-657b-4d01-af5d-cd813bc5dd2f)

