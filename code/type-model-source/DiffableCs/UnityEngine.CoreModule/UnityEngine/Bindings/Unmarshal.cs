namespace UnityEngine.Bindings;

[Token(Token = "0x200024E")]
[VisibleToOtherModules]
internal struct Unmarshal
{

	[Address(RVA = "0x3097530", Offset = "0x3096930", Length = "0x2E")]
	[Token(Token = "0x6001834")]
	public static GCHandle FromIntPtrUnsafe(IntPtr gcHandle) { }

	[Address(RVA = "0x9D7400", Offset = "0x9D6800", Length = "0xB0")]
	[Token(Token = "0x6001833")]
	public static T UnmarshalUnityObject(IntPtr gcHandlePtr) { }

}

