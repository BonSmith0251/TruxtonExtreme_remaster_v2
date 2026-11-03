namespace UnityEngine.VFX;

[NativeType(Header = "Modules/VFX/Public/VFXExpressionValues.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000006")]
public class VFXExpressionValues
{
	[Token(Token = "0x2000007")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000039")]
		public static IntPtr ConvertToNative(VFXExpressionValues vFXExpressionValues) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000D")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600002D")]
	private VFXExpressionValues() { }

	[Address(RVA = "0x3480E00", Offset = "0x3480200", Length = "0x5E")]
	[RequiredByNativeCode]
	[Token(Token = "0x600002E")]
	internal static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr) { }

	[Address(RVA = "0x3480EA0", Offset = "0x34802A0", Length = "0x58")]
	[NativeName("GetValueFromScript<bool>")]
	[NativeThrows]
	[Token(Token = "0x600002F")]
	public bool GetBool(int nameID) { }

	[Address(RVA = "0x3480E60", Offset = "0x3480260", Length = "0x40")]
	[Token(Token = "0x6000034")]
	private static bool GetBool_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3480F40", Offset = "0x3480340", Length = "0x58")]
	[NativeName("GetValueFromScript<float>")]
	[NativeThrows]
	[Token(Token = "0x6000032")]
	public float GetFloat(int nameID) { }

	[Address(RVA = "0x3480F00", Offset = "0x3480300", Length = "0x40")]
	[Token(Token = "0x6000037")]
	private static float GetFloat_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3480FE0", Offset = "0x34803E0", Length = "0x58")]
	[NativeName("GetValueFromScript<int>")]
	[NativeThrows]
	[Token(Token = "0x6000030")]
	public int GetInt(int nameID) { }

	[Address(RVA = "0x3480FA0", Offset = "0x34803A0", Length = "0x40")]
	[Token(Token = "0x6000035")]
	private static int GetInt_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3481080", Offset = "0x3480480", Length = "0x58")]
	[NativeName("GetValueFromScript<UInt32>")]
	[NativeThrows]
	[Token(Token = "0x6000031")]
	public uint GetUInt(int nameID) { }

	[Address(RVA = "0x3481040", Offset = "0x3480440", Length = "0x40")]
	[Token(Token = "0x6000036")]
	private static uint GetUInt_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3481130", Offset = "0x3480530", Length = "0x79")]
	[NativeName("GetValueFromScript<Vector3f>")]
	[NativeThrows]
	[Token(Token = "0x6000033")]
	public Vector3 GetVector3(int nameID) { }

	[Address(RVA = "0x34810E0", Offset = "0x34804E0", Length = "0x50")]
	[Token(Token = "0x6000038")]
	private static void GetVector3_Injected(IntPtr _unity_self, int nameID, out Vector3 ret) { }

}

