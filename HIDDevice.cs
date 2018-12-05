using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace HFReader
{
        class HIDDevice
        { 
                // Return Codes
                public const Int32 HID_DEVICE_SUCCESS = 0x00;
                public const Int32 HID_DEVICE_NOT_FOUND = 0x01;
                public const Int32 HID_DEVICE_NOT_OPENED = 0x02;
                public const Int32 HID_DEVICE_ALREADY_OPENED = 0x03;
                public const Int32 HID_DEVICE_TRANSFER_TIMEOUT = 0x04;
                public const Int32 HID_DEVICE_TRANSFER_FAILED = 0x05;
                public const Int32 HID_DEVICE_CANNOT_GET_HID_INFO = 0x06;
                public const Int32 HID_DEVICE_HANDLE_ERROR = 0x07;
                public const Int32 HID_DEVICE_INVALID_BUFFER_SIZE = 0x08;
                public const Int32 HID_DEVICE_SYSTEM_CODE = 0x09;
                public const Int32 HID_DEVICE_UNSUPPORTED_FUNCTION = 0x0A;
                public const Int32 HID_DEVICE_UNKNOWN_ERROR = 0xFF;

                // Max number of USB Devices allowed
                public const Int32 MAX_USB_DEVICES = 64;

                // Max number of reports that can be requested at time
                public const Int32 MAX_REPORT_REQUEST_XP = 512;
                public const Int32 MAX_REPORT_REQUEST_2K = 200;

                public const Int32 DEFAULT_REPORT_INPUT_BUFFERS = 0;

                // String Types
                public const Byte HID_VID_STRING = 0x01;
                public const Byte HID_PID_STRING = 0x02;
                public const Byte HID_PATH_STRING = 0x03;
                public const Byte HID_SERIAL_STRING = 0x04;
                public const Byte HID_MANUFACTURER_STRING = 0x05;
                public const Byte HID_PRODUCT_STRING = 0x06;

                // String Lengths
                public const Int32 MAX_VID_LENGTH = 5;
                public const Int32 MAX_PID_LENGTH = 5;
                public const Int32 MAX_PATH_LENGTH = 260;
                public const Int32 MAX_SERIAL_STRING_LENGTH = 256;
                public const Int32 MAX_MANUFACTURER_STRING_LENGTH = 256;
                public const Int32 MAX_PRODUCT_STRING_LENGTH = 256;
                public const Int32 MAX_INDEXED_STRING_LENGTH = 256;
                public const Int32 MAX_STRING_LENGTH = 260;

                //public static Int32 Status;
                //public static IntPtr HID_DEVICE;
                //public Type HID_DEVICE=Object;

                //SLAB_HID_DEVICE_API	int	WINAPI	HidDevice_GetNumHidDevices(WORD vid, WORD pid);
                [DllImport("SLABHIDDevice.dll")]
                public static extern Int32 HidDevice_GetNumHidDevices(UInt16 vid, UInt16 pid);

                //SLAB_HID_DEVICE_API	BYTE	WINAPI	HidDevice_GetHidString(DWORD deviceIndex, WORD vid, WORD pid, BYTE hidStringType, char* deviceString, DWORD deviceStringLength);
                [DllImport("SLABHIDDevice.dll")]
                public static extern Byte HidDevice_GetHidString(Int32 deviceIndex, UInt16 vid, UInt16 pid, Byte hidStringType, IntPtr pDeviceString, Int32 deviceStringLength);

                //SLAB_HID_DEVICE_API	BYTE	WINAPI	HidDevice_GetHidIndexedString(DWORD deviceIndex, WORD vid, WORD pid, DWORD stringIndex, char* deviceString, DWORD deviceStringLength);
                //[DllImport("SLABHIDDevice.dll")]
                //public static extern Byte HidDevice_GetHidIndexedString(Int32 deviceIndex, UInt16 vid, UInt16 pid, Int32 stringIndex, ref String deviceString, Int32 deviceStringLength);

                //SLAB_HID_DEVICE_API	BYTE	WINAPI	HidDevice_GetHidAttributes(DWORD deviceIndex, WORD vid, WORD pid, WORD* deviceVid, WORD* devicePid, WORD* deviceReleaseNumber);
                //[DllImport("SLABHIDDevice.dll")]
                //public static extern Byte HidDevice_GetHidAttributes(Int32 deviceIndex, UInt16 vid, UInt16 pid, ref UInt16 deviceVid, ref UInt16 devicePid, ref UInt16 deviceReleaseNumber);

                //SLAB_HID_DEVICE_API	void	WINAPI	HidDevice_GetHidGuid(void* hidGuid);
                //[DllImport("SLABHIDDevice.dll")]
                //public static extern void HidDevice_GetHidGuid(ref Object hidGuid);

                ////SLAB_HID_DEVICE_API	BYTE	WINAPI	HidDevice_GetHidLibraryVersion(BYTE* major, BYTE* minor, BOOL* release);
                //[DllImport("SLABHIDDevice.dll")]
                //public static extern Byte HidDevice_GetHidLibraryVersion(ref Byte major, ref Byte minor, ref Boolean release);

                //SLAB_HID_DEVICE_API	BYTE	WINAPI	HidDevice_Open(HID_DEVICE* device, DWORD deviceIndex, WORD vid, WORD pid, DWORD numInputBuffers);
                [DllImport("SLABHIDDevice.dll")]
                public static extern Byte HidDevice_Open(IntPtr device, Int32 deviceIndex, UInt16 vid, UInt16 pid, Int32 numInputBuffers);

                //SLAB_HID_DEVICE_API	BOOL	WINAPI	HidDevice_IsOpened(HID_DEVICE device);
                [DllImport("SLABHIDDevice.dll")]
                public static extern Boolean HidDevice_IsOpened(Int32 device);

                //SLAB_HID_DEVICE_API	HANDLE	WINAPI	HidDevice_GetHandle(HID_DEVICE device);
                //[DllImport("SLABHIDDevice.dll")]
                //public static extern IntPtr HidDevice_GetHandle(IntPtr device);

                ////SLAB_HID_DEVICE_API	BYTE	WINAPI	HidDevice_GetString(HID_DEVICE device, BYTE hidStringType, char* deviceString, DWORD deviceStringLength);
                //[DllImport("SLABHIDDevice.dll")]
                //public static extern Byte HidDevice_GetString(Int32 device, Byte hidStringType, ref String deviceString, Int32 deviceStringLength);

                ////SLAB_HID_DEVICE_API	BYTE	WINAPI	HidDevice_GetIndexedString(HID_DEVICE device, DWORD stringIndex, char* deviceString, DWORD deviceStringLength);
                //[DllImport("SLABHIDDevice.dll")]
                //public static extern Byte HidDevice_GetIndexedString(Int32 device, Int32 stringIndex, ref String deviceString, Int32 deviceStringLength);

                ////SLAB_HID_DEVICE_API	BYTE	WINAPI	HidDevice_GetAttributes(HID_DEVICE device, WORD* deviceVid, WORD* devicePid, WORD* deviceReleaseNumber);
                //[DllImport("SLABHIDDevice.dll")]
                //public static extern Byte HidDevice_GetAttributes(Int32 device, Int32 stringIndex, ref String deviceString, Int32 deviceStringLength);

                ////SLAB_HID_DEVICE_API	BYTE	WINAPI	HidDevice_SetFeatureReport_Control(HID_DEVICE device, BYTE* buffer, DWORD bufferSize);
                //[DllImport("SLABHIDDevice.dll")]
                //public static extern Byte HidDevice_SetFeatureReport_Control(Int32 device, ref Byte[] buffer, Int32 bufferSize);

                ////SLAB_HID_DEVICE_API	BYTE	WINAPI	HidDevice_GetFeatureReport_Control(HID_DEVICE device, BYTE* buffer, DWORD bufferSize);
                //[DllImport("SLABHIDDevice.dll")]
                //public static extern Byte HidDevice_GetFeatureReport_Control(Int32 device, ref Byte[] buffer, Int32 bufferSize);

                //SLAB_HID_DEVICE_API	BYTE	WINAPI	HidDevice_SetOutputReport_Interrupt(HID_DEVICE device, BYTE* buffer, DWORD bufferSize);
                [DllImport("SLABHIDDevice.dll")]
                public static extern Byte HidDevice_SetOutputReport_Interrupt(Int32 device, IntPtr pBuffer, Int32 bufferSize);

                //SLAB_HID_DEVICE_API	BYTE	WINAPI	HidDevice_GetInputReport_Interrupt(HID_DEVICE device, BYTE* buffer, DWORD bufferSize, DWORD numReports, DWORD* bytesReturned);
                [DllImport("SLABHIDDevice.dll")]
                public static extern Byte HidDevice_GetInputReport_Interrupt(Int32 device, IntPtr pBuffer, Int32 bufferSize, Int32 numReports, ref Int32 bytesReturned);

                ////SLAB_HID_DEVICE_API BYTE	WINAPI	HidDevice_SetOutputReport_Control(HID_DEVICE device, BYTE* buffer, DWORD bufferSize);
                //[DllImport("SLABHIDDevice.dll")]
                //public static extern Byte HidDevice_SetOutputReport_Control(Int32 device, ref Byte[] buffer, Int32 bufferSize);

                ////SLAB_HID_DEVICE_API BYTE	WINAPI	HidDevice_GetInputReport_Control(HID_DEVICE device, BYTE* buffer, DWORD bufferSize);
                //[DllImport("SLABHIDDevice.dll")]
                //public static extern Byte HidDevice_GetInputReport_Control(Int32 device, ref Byte[] buffer, Int32 bufferSize);


                //SLAB_HID_DEVICE_API	WORD	WINAPI	HidDevice_GetInputReportBufferLength(HID_DEVICE device);
                [DllImport("SLABHIDDevice.dll")]
                public static extern UInt16 HidDevice_GetInputReportBufferLength(Int32 device);

                //SLAB_HID_DEVICE_API	WORD	WINAPI	HidDevice_GetOutputReportBufferLength(HID_DEVICE device);
                [DllImport("SLABHIDDevice.dll")]
                public static extern UInt16 HidDevice_GetOutputReportBufferLength(Int32 device);

                //SLAB_HID_DEVICE_API	WORD	WINAPI	HidDevice_GetFeatureReportBufferLength(HID_DEVICE device);
                [DllImport("SLABHIDDevice.dll")]
                public static extern UInt16 HidDevice_GetFeatureReportBufferLength(Int32 device);

                //SLAB_HID_DEVICE_API	DWORD	WINAPI	HidDevice_GetMaxReportRequest(HID_DEVICE device);
                [DllImport("SLABHIDDevice.dll")]
                public static extern Int32 HidDevice_GetMaxReportRequest(Int32 device);

                //SLAB_HID_DEVICE_API	BOOL	WINAPI	HidDevice_FlushBuffers(HID_DEVICE device);
                [DllImport("SLABHIDDevice.dll")]
                public static extern Boolean HidDevice_FlushBuffers(Int32 device);

                //SLAB_HID_DEVICE_API	BOOL	WINAPI	HidDevice_CancelIo(HID_DEVICE device);
                [DllImport("SLABHIDDevice.dll")]
                public static extern Boolean HidDevice_CancelIo(Int32 device);

                //SLAB_HID_DEVICE_API	void	WINAPI	HidDevice_GetTimeouts(HID_DEVICE device, DWORD* getReportTimeout, DWORD* setReportTimeout);
                [DllImport("SLABHIDDevice.dll")]
                public static extern void HidDevice_GetTimeouts(Int32 device, ref Int32 getReportTimeout, ref Int32 setReportTimeout);

                //SLAB_HID_DEVICE_API	void	WINAPI	HidDevice_SetTimeouts(HID_DEVICE device, DWORD getReportTimeout, DWORD setReportTimeout);
                [DllImport("SLABHIDDevice.dll")]
                public static extern void HidDevice_SetTimeouts(Int32 device, Int32 getReportTimeout, Int32 setReportTimeout);

                //SLAB_HID_DEVICE_API	BYTE	WINAPI	HidDevice_Close(HID_DEVICE device);
                [DllImport("SLABHIDDevice.dll")]
                public static extern Byte HidDevice_Close(Int32 device);

        }
}
