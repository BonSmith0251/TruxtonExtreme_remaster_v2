namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Math/SphericalHarmonicsL2.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Shaders/ShaderPropertySheet.h")]
[Token(Token = "0x20000EA")]
public sealed class MaterialPropertyBlock
{
	[Token(Token = "0x20000EB")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x600076E")]
		public static IntPtr ConvertToNative(MaterialPropertyBlock materialPropertyBlock) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000287")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x3002940", Offset = "0x3001D40", Length = "0x3B")]
	[Token(Token = "0x600074A")]
	public MaterialPropertyBlock() { }

	[Address(RVA = "0x3000CD0", Offset = "0x30000D0", Length = "0x5B")]
	[ThreadSafe]
	[Token(Token = "0x6000745")]
	private void Clear(bool keepMemory) { }

	[Address(RVA = "0x3000D30", Offset = "0x3000130", Length = "0x53")]
	[Token(Token = "0x6000746")]
	public void Clear() { }

	[Address(RVA = "0x3000C80", Offset = "0x3000080", Length = "0x42")]
	[Token(Token = "0x600076D")]
	private static void Clear_Injected(IntPtr _unity_self, bool keepMemory) { }

	[Address(RVA = "0x3000D90", Offset = "0x3000190", Length = "0x2A")]
	[NativeMethod(Name = "MaterialPropertyBlockScripting::Create", IsFreeFunction = True)]
	[Token(Token = "0x6000743")]
	private static IntPtr CreateImpl() { }

	[Address(RVA = "0x3000DC0", Offset = "0x30001C0", Length = "0x33")]
	[NativeMethod(Name = "MaterialPropertyBlockScripting::Destroy", IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x6000744")]
	private static void DestroyImpl(IntPtr mpb) { }

	[Address(RVA = "0x3000E00", Offset = "0x3000200", Length = "0x8A")]
	[Token(Token = "0x600074C")]
	private void Dispose() { }

	[Address(RVA = "0x3000E90", Offset = "0x3000290", Length = "0xCE")]
	[Token(Token = "0x600074B")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x3000FB0", Offset = "0x30003B0", Length = "0x7E")]
	[Token(Token = "0x6000758")]
	public void SetBuffer(int nameID, ComputeBuffer value) { }

	[Address(RVA = "0x3001030", Offset = "0x3000430", Length = "0x9F")]
	[Token(Token = "0x6000757")]
	public void SetBuffer(string name, ComputeBuffer value) { }

	[Address(RVA = "0x3000FB0", Offset = "0x30003B0", Length = "0x7E")]
	[NativeName("SetBufferFromScript")]
	[ThreadSafe]
	[Token(Token = "0x600073E")]
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[Address(RVA = "0x3000F60", Offset = "0x3000360", Length = "0x50")]
	[Token(Token = "0x6000768")]
	private static void SetBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	[Address(RVA = "0x3001190", Offset = "0x3000590", Length = "0x84")]
	[Token(Token = "0x6000754")]
	public void SetColor(string name, Color value) { }

	[Address(RVA = "0x3001120", Offset = "0x3000520", Length = "0x67")]
	[NativeName("SetColorFromScript")]
	[ThreadSafe]
	[Token(Token = "0x600073A")]
	private void SetColorImpl(int name, Color value) { }

	[Address(RVA = "0x30010D0", Offset = "0x30004D0", Length = "0x50")]
	[Token(Token = "0x6000764")]
	private static void SetColorImpl_Injected(IntPtr _unity_self, int name, in Color value) { }

	[Address(RVA = "0x3001280", Offset = "0x3000680", Length = "0x92")]
	[Token(Token = "0x600075C")]
	public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	[Address(RVA = "0x3001280", Offset = "0x3000680", Length = "0x92")]
	[NativeName("SetConstantBufferFromScript")]
	[ThreadSafe]
	[Token(Token = "0x600073F")]
	private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	[Address(RVA = "0x3001220", Offset = "0x3000620", Length = "0x60")]
	[Token(Token = "0x6000769")]
	private static void SetConstantBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value, int offset, int size) { }

	[Address(RVA = "0x30017C0", Offset = "0x3000BC0", Length = "0x84")]
	[Token(Token = "0x600074F")]
	public void SetFloat(string name, float value) { }

	[Address(RVA = "0x3001750", Offset = "0x3000B50", Length = "0x68")]
	[Token(Token = "0x6000750")]
	public void SetFloat(int nameID, float value) { }

	[Address(RVA = "0x30016B0", Offset = "0x3000AB0", Length = "0x4C")]
	[Token(Token = "0x600075D")]
	public void SetFloatArray(string name, Single[] values) { }

	[Address(RVA = "0x30014A0", Offset = "0x30008A0", Length = "0x204")]
	[Token(Token = "0x6000747")]
	private void SetFloatArray(int name, Single[] values, int count) { }

	[Address(RVA = "0x3001380", Offset = "0x3000780", Length = "0x11A")]
	[NativeName("SetFloatArrayFromScript")]
	[ThreadSafe]
	[Token(Token = "0x6000740")]
	private void SetFloatArrayImpl(int name, Single[] values, int count) { }

	[Address(RVA = "0x3001320", Offset = "0x3000720", Length = "0x60")]
	[Token(Token = "0x600076A")]
	private static void SetFloatArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	[Address(RVA = "0x3001750", Offset = "0x3000B50", Length = "0x68")]
	[NativeName("SetFloatFromScript")]
	[ThreadSafe]
	[Token(Token = "0x6000738")]
	private void SetFloatImpl(int name, float value) { }

	[Address(RVA = "0x3001700", Offset = "0x3000B00", Length = "0x50")]
	[Token(Token = "0x6000762")]
	private static void SetFloatImpl_Injected(IntPtr _unity_self, int name, float value) { }

	[Address(RVA = "0x3001910", Offset = "0x3000D10", Length = "0x95")]
	[Token(Token = "0x600074D")]
	public void SetInt(string name, int value) { }

	[Address(RVA = "0x30019B0", Offset = "0x3000DB0", Length = "0x78")]
	[Token(Token = "0x600074E")]
	public void SetInt(int nameID, int value) { }

	[Address(RVA = "0x30018A0", Offset = "0x3000CA0", Length = "0x67")]
	[Token(Token = "0x6000751")]
	public void SetInteger(int nameID, int value) { }

	[Address(RVA = "0x30018A0", Offset = "0x3000CA0", Length = "0x67")]
	[NativeName("SetIntFromScript")]
	[ThreadSafe]
	[Token(Token = "0x6000737")]
	private void SetIntImpl(int name, int value) { }

	[Address(RVA = "0x3001850", Offset = "0x3000C50", Length = "0x50")]
	[Token(Token = "0x6000761")]
	private static void SetIntImpl_Injected(IntPtr _unity_self, int name, int value) { }

	[Address(RVA = "0x3001F60", Offset = "0x3001360", Length = "0x9F")]
	[Token(Token = "0x6000755")]
	public void SetMatrix(string name, Matrix4x4 value) { }

	[Address(RVA = "0x3001ED0", Offset = "0x30012D0", Length = "0x84")]
	[Token(Token = "0x6000756")]
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	[Address(RVA = "0x3001C00", Offset = "0x3001000", Length = "0x204")]
	[Token(Token = "0x6000749")]
	private void SetMatrixArray(int name, Matrix4x4[] values, int count) { }

	[Address(RVA = "0x3001BB0", Offset = "0x3000FB0", Length = "0x4C")]
	[Token(Token = "0x6000760")]
	public void SetMatrixArray(string name, Matrix4x4[] values) { }

	[Address(RVA = "0x3001A90", Offset = "0x3000E90", Length = "0x11A")]
	[NativeName("SetMatrixArrayFromScript")]
	[ThreadSafe]
	[Token(Token = "0x6000742")]
	private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[Address(RVA = "0x3001A30", Offset = "0x3000E30", Length = "0x60")]
	[Token(Token = "0x600076C")]
	private static void SetMatrixArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	[Address(RVA = "0x3001E60", Offset = "0x3001260", Length = "0x67")]
	[NativeName("SetMatrixFromScript")]
	[ThreadSafe]
	[Token(Token = "0x600073B")]
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[Address(RVA = "0x3001E10", Offset = "0x3001210", Length = "0x50")]
	[Token(Token = "0x6000765")]
	private static void SetMatrixImpl_Injected(IntPtr _unity_self, int name, in Matrix4x4 value) { }

	[Address(RVA = "0x3002060", Offset = "0x3001460", Length = "0xE9")]
	[NativeName("SetRenderTextureFromScript")]
	[ThreadSafe]
	[Token(Token = "0x600073D")]
	private void SetRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	[Address(RVA = "0x3002000", Offset = "0x3001400", Length = "0x60")]
	[Token(Token = "0x6000767")]
	private static void SetRenderTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value, RenderTextureSubElement element) { }

	[Address(RVA = "0x3002280", Offset = "0x3001680", Length = "0xE2")]
	[Token(Token = "0x6000759")]
	public void SetTexture(string name, Texture value) { }

	[Address(RVA = "0x30021A0", Offset = "0x30015A0", Length = "0xD5")]
	[Token(Token = "0x600075A")]
	public void SetTexture(int nameID, Texture value) { }

	[Address(RVA = "0x3002060", Offset = "0x3001460", Length = "0xE9")]
	[Token(Token = "0x600075B")]
	public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	[Address(RVA = "0x30021A0", Offset = "0x30015A0", Length = "0xD5")]
	[NativeName("SetTextureFromScript")]
	[ThreadSafe]
	[Token(Token = "0x600073C")]
	private void SetTextureImpl(int name, Texture value) { }

	[Address(RVA = "0x3002150", Offset = "0x3001550", Length = "0x50")]
	[Token(Token = "0x6000766")]
	private static void SetTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	[Address(RVA = "0x30028B0", Offset = "0x3001CB0", Length = "0x84")]
	[Token(Token = "0x6000752")]
	public void SetVector(string name, Vector4 value) { }

	[Address(RVA = "0x3002840", Offset = "0x3001C40", Length = "0x66")]
	[Token(Token = "0x6000753")]
	public void SetVector(int nameID, Vector4 value) { }

	[Address(RVA = "0x30024F0", Offset = "0x30018F0", Length = "0x25")]
	[Token(Token = "0x600075F")]
	public void SetVectorArray(int nameID, Vector4[] values) { }

	[Address(RVA = "0x3002730", Offset = "0x3001B30", Length = "0x4C")]
	[Token(Token = "0x600075E")]
	public void SetVectorArray(string name, Vector4[] values) { }

	[Address(RVA = "0x3002520", Offset = "0x3001920", Length = "0x204")]
	[Token(Token = "0x6000748")]
	private void SetVectorArray(int name, Vector4[] values, int count) { }

	[Address(RVA = "0x30023D0", Offset = "0x30017D0", Length = "0x11A")]
	[NativeName("SetVectorArrayFromScript")]
	[ThreadSafe]
	[Token(Token = "0x6000741")]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	[Address(RVA = "0x3002370", Offset = "0x3001770", Length = "0x60")]
	[Token(Token = "0x600076B")]
	private static void SetVectorArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	[Address(RVA = "0x30027D0", Offset = "0x3001BD0", Length = "0x67")]
	[NativeName("SetVectorFromScript")]
	[ThreadSafe]
	[Token(Token = "0x6000739")]
	private void SetVectorImpl(int name, Vector4 value) { }

	[Address(RVA = "0x3002780", Offset = "0x3001B80", Length = "0x50")]
	[Token(Token = "0x6000763")]
	private static void SetVectorImpl_Injected(IntPtr _unity_self, int name, in Vector4 value) { }

}

