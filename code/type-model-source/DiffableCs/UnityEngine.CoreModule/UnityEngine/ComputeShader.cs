namespace UnityEngine;

[NativeHeader("Runtime/Graphics/RayTracing/RayTracingAccelerationStructure.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[Token(Token = "0x20001E2")]
[UsedByNativeCode]
public sealed class ComputeShader : object
{

	[Token(Token = "0x17000303")]
	public LocalKeyword[] enabledKeywords
	{
		[Address(RVA = "0x305AB70", Offset = "0x3059F70", Length = "0x76")]
		[Token(Token = "0x6001513")]
		 get { } //Length: 118
		[Address(RVA = "0x305C310", Offset = "0x305B710", Length = "0x85")]
		[Token(Token = "0x6001514")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000301")]
	public LocalKeywordSpace keywordSpace
	{
		[Address(RVA = "0x305DFA0", Offset = "0x305D3A0", Length = "0x89")]
		[Token(Token = "0x6001500")]
		 get { } //Length: 137
	}

	[Token(Token = "0x17000302")]
	public String[] shaderKeywords
	{
		[Address(RVA = "0x305AD40", Offset = "0x305A140", Length = "0x76")]
		[Token(Token = "0x600150F")]
		 get { } //Length: 118
		[Address(RVA = "0x305D2F0", Offset = "0x305C6F0", Length = "0x85")]
		[Token(Token = "0x6001510")]
		 set { } //Length: 133
	}

	[Address(RVA = "0x305DF00", Offset = "0x305D300", Length = "0x49")]
	[Token(Token = "0x6001515")]
	private ComputeShader() { }

	[Address(RVA = "0x3059F00", Offset = "0x3059300", Length = "0x8E")]
	[Token(Token = "0x6001509")]
	public void DisableKeyword(in LocalKeyword keyword) { }

	[Address(RVA = "0x3059D30", Offset = "0x3059130", Length = "0x1C7")]
	[FreeFunction("ComputeShaderScripting::DisableKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001502")]
	public void DisableKeyword(string keyword) { }

	[Address(RVA = "0x3059CE0", Offset = "0x30590E0", Length = "0x42")]
	[Token(Token = "0x600154B")]
	private static void DisableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x3059FE0", Offset = "0x30593E0", Length = "0x85")]
	[FreeFunction("ComputeShaderScripting::DisableKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001505")]
	private void DisableLocalKeyword(LocalKeyword keyword) { }

	[Address(RVA = "0x3059F90", Offset = "0x3059390", Length = "0x42")]
	[Token(Token = "0x600154E")]
	private static void DisableLocalKeyword_Injected(IntPtr _unity_self, in LocalKeyword keyword) { }

	[Address(RVA = "0x305A4D0", Offset = "0x30598D0", Length = "0xA7")]
	[NativeName("DispatchComputeShader")]
	[Token(Token = "0x60014FD")]
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[Address(RVA = "0x305A470", Offset = "0x3059870", Length = "0x60")]
	[Token(Token = "0x6001546")]
	private static void Dispatch_Injected(IntPtr _unity_self, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[Address(RVA = "0x305A070", Offset = "0x3059470", Length = "0x1DC")]
	[Token(Token = "0x6001531")]
	public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer, uint argsOffset) { }

	[Address(RVA = "0x305A290", Offset = "0x3059690", Length = "0x1DC")]
	[Token(Token = "0x600152F")]
	public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset) { }

	[Address(RVA = "0x305A270", Offset = "0x3059670", Length = "0x1A")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001530")]
	public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer) { }

	[Address(RVA = "0x305A250", Offset = "0x3059650", Length = "0x1A")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001532")]
	public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer) { }

	[Address(RVA = "0x305A5D0", Offset = "0x30599D0", Length = "0x8E")]
	[Token(Token = "0x6001508")]
	public void EnableKeyword(in LocalKeyword keyword) { }

	[Address(RVA = "0x305A660", Offset = "0x3059A60", Length = "0x1C7")]
	[FreeFunction("ComputeShaderScripting::EnableKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001501")]
	public void EnableKeyword(string keyword) { }

	[Address(RVA = "0x305A580", Offset = "0x3059980", Length = "0x42")]
	[Token(Token = "0x600154A")]
	private static void EnableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x305A880", Offset = "0x3059C80", Length = "0x85")]
	[FreeFunction("ComputeShaderScripting::EnableKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001504")]
	private void EnableLocalKeyword(LocalKeyword keyword) { }

	[Address(RVA = "0x305A830", Offset = "0x3059C30", Length = "0x42")]
	[Token(Token = "0x600154D")]
	private static void EnableLocalKeyword_Injected(IntPtr _unity_self, in LocalKeyword keyword) { }

	[Address(RVA = "0x305A960", Offset = "0x3059D60", Length = "0x1CD")]
	[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	[RequiredByNativeCode]
	[Token(Token = "0x60014E7")]
	public int FindKernel(string name) { }

	[Address(RVA = "0x305A910", Offset = "0x3059D10", Length = "0x42")]
	[Token(Token = "0x6001533")]
	private static int FindKernel_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x305AB70", Offset = "0x3059F70", Length = "0x76")]
	[Token(Token = "0x6001513")]
	public LocalKeyword[] get_enabledKeywords() { }

	[Address(RVA = "0x305DFA0", Offset = "0x305D3A0", Length = "0x89")]
	[Token(Token = "0x6001500")]
	public LocalKeywordSpace get_keywordSpace() { }

	[Address(RVA = "0x305DF50", Offset = "0x305D350", Length = "0x42")]
	[Token(Token = "0x6001549")]
	private static void get_keywordSpace_Injected(IntPtr _unity_self, out LocalKeywordSpace ret) { }

	[Address(RVA = "0x305AD40", Offset = "0x305A140", Length = "0x76")]
	[Token(Token = "0x600150F")]
	public String[] get_shaderKeywords() { }

	[Address(RVA = "0x305AB70", Offset = "0x3059F70", Length = "0x76")]
	[FreeFunction("ComputeShaderScripting::GetEnabledKeywords", HasExplicitThis = True)]
	[Token(Token = "0x6001511")]
	private LocalKeyword[] GetEnabledKeywords() { }

	[Address(RVA = "0x305AB30", Offset = "0x3059F30", Length = "0x33")]
	[Token(Token = "0x6001554")]
	private static LocalKeyword[] GetEnabledKeywords_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x305AC50", Offset = "0x305A050", Length = "0xA7")]
	[NativeMethod(Name = "ComputeShaderScripting::GetKernelThreadGroupSizes", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x60014FC")]
	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z) { }

	[Address(RVA = "0x305ABF0", Offset = "0x3059FF0", Length = "0x60")]
	[Token(Token = "0x6001545")]
	private static void GetKernelThreadGroupSizes_Injected(IntPtr _unity_self, int kernelIndex, out uint x, out uint y, out uint z) { }

	[Address(RVA = "0x305AD40", Offset = "0x305A140", Length = "0x76")]
	[FreeFunction("ComputeShaderScripting::GetShaderKeywords", HasExplicitThis = True)]
	[Token(Token = "0x600150D")]
	private String[] GetShaderKeywords() { }

	[Address(RVA = "0x305AD00", Offset = "0x305A100", Length = "0x33")]
	[Token(Token = "0x6001552")]
	private static String[] GetShaderKeywords_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x305AE10", Offset = "0x305A210", Length = "0x1CE")]
	[FreeFunction(Name = "ComputeShaderScripting::HasKernel", HasExplicitThis = True)]
	[Token(Token = "0x60014E8")]
	public bool HasKernel(string name) { }

	[Address(RVA = "0x305ADC0", Offset = "0x305A1C0", Length = "0x42")]
	[Token(Token = "0x6001534")]
	private static bool HasKernel_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x305B190", Offset = "0x305A590", Length = "0xE9")]
	[FreeFunction(Name = "ComputeShaderScripting::DispatchIndirect", HasExplicitThis = True)]
	[Token(Token = "0x60014FE")]
	private void Internal_DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset) { }

	[Address(RVA = "0x305B130", Offset = "0x305A530", Length = "0x60")]
	[Token(Token = "0x6001547")]
	private static void Internal_DispatchIndirect_Injected(IntPtr _unity_self, int kernelIndex, IntPtr argsBuffer, uint argsOffset) { }

	[Address(RVA = "0x305B040", Offset = "0x305A440", Length = "0xE9")]
	[FreeFunction(Name = "ComputeShaderScripting::DispatchIndirect", HasExplicitThis = True)]
	[Token(Token = "0x60014FF")]
	private void Internal_DispatchIndirectGraphicsBuffer(int kernelIndex, GraphicsBuffer argsBuffer, uint argsOffset) { }

	[Address(RVA = "0x305AFE0", Offset = "0x305A3E0", Length = "0x60")]
	[Token(Token = "0x6001548")]
	private static void Internal_DispatchIndirectGraphicsBuffer_Injected(IntPtr _unity_self, int kernelIndex, IntPtr argsBuffer, uint argsOffset) { }

	[Address(RVA = "0x305B2E0", Offset = "0x305A6E0", Length = "0xE9")]
	[FreeFunction(Name = "ComputeShaderScripting::SetBuffer", HasExplicitThis = True)]
	[Token(Token = "0x60014F4")]
	private void Internal_SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[Address(RVA = "0x305B280", Offset = "0x305A680", Length = "0x60")]
	[Token(Token = "0x6001540")]
	private static void Internal_SetBuffer_Injected(IntPtr _unity_self, int kernelIndex, int nameID, IntPtr buffer) { }

	[Address(RVA = "0x305B430", Offset = "0x305A830", Length = "0xE9")]
	[FreeFunction(Name = "ComputeShaderScripting::SetBuffer", HasExplicitThis = True)]
	[Token(Token = "0x60014F5")]
	private void Internal_SetGraphicsBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer) { }

	[Address(RVA = "0x305B3D0", Offset = "0x305A7D0", Length = "0x60")]
	[Token(Token = "0x6001541")]
	private static void Internal_SetGraphicsBuffer_Injected(IntPtr _unity_self, int kernelIndex, int nameID, IntPtr buffer) { }

	[Address(RVA = "0x305B580", Offset = "0x305A980", Length = "0xE9")]
	[FreeFunction(Name = "ComputeShaderScripting::SetRayTracingAccelerationStructure", HasExplicitThis = True)]
	[Token(Token = "0x60014F6")]
	private void Internal_SetRayTracingAccelerationStructure(int kernelIndex, int nameID, RayTracingAccelerationStructure accelerationStructure) { }

	[Address(RVA = "0x305B520", Offset = "0x305A920", Length = "0x60")]
	[Token(Token = "0x6001542")]
	private static void Internal_SetRayTracingAccelerationStructure_Injected(IntPtr _unity_self, int kernelIndex, int nameID, IntPtr accelerationStructure) { }

	[Address(RVA = "0x305B6C0", Offset = "0x305AAC0", Length = "0x1CE")]
	[FreeFunction("ComputeShaderScripting::IsKeywordEnabled", HasExplicitThis = True)]
	[Token(Token = "0x6001503")]
	public bool IsKeywordEnabled(string keyword) { }

	[Address(RVA = "0x305B890", Offset = "0x305AC90", Length = "0x8E")]
	[Token(Token = "0x600150B")]
	public bool IsKeywordEnabled(in LocalKeyword keyword) { }

	[Address(RVA = "0x305B670", Offset = "0x305AA70", Length = "0x42")]
	[Token(Token = "0x600154C")]
	private static bool IsKeywordEnabled_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x305B970", Offset = "0x305AD70", Length = "0x85")]
	[FreeFunction("ComputeShaderScripting::IsKeywordEnabled", HasExplicitThis = True)]
	[Token(Token = "0x6001507")]
	private bool IsLocalKeywordEnabled(LocalKeyword keyword) { }

	[Address(RVA = "0x305B920", Offset = "0x305AD20", Length = "0x42")]
	[Token(Token = "0x6001550")]
	private static bool IsLocalKeywordEnabled_Injected(IntPtr _unity_self, in LocalKeyword keyword) { }

	[Address(RVA = "0x305BA40", Offset = "0x305AE40", Length = "0x83")]
	[FreeFunction("ComputeShaderScripting::IsSupported", HasExplicitThis = True)]
	[Token(Token = "0x600150C")]
	public bool IsSupported(int kernelIndex) { }

	[Address(RVA = "0x305BA00", Offset = "0x305AE00", Length = "0x40")]
	[Token(Token = "0x6001551")]
	private static bool IsSupported_Injected(IntPtr _unity_self, int kernelIndex) { }

	[Address(RVA = "0x305C310", Offset = "0x305B710", Length = "0x85")]
	[Token(Token = "0x6001514")]
	public void set_enabledKeywords(LocalKeyword[] value) { }

	[Address(RVA = "0x305D2F0", Offset = "0x305C6F0", Length = "0x85")]
	[Token(Token = "0x6001510")]
	public void set_shaderKeywords(String[] value) { }

	[Address(RVA = "0x305BB80", Offset = "0x305AF80", Length = "0x94")]
	[Token(Token = "0x6001521")]
	public void SetBool(int nameID, bool val) { }

	[Address(RVA = "0x305BAD0", Offset = "0x305AED0", Length = "0xA1")]
	[Token(Token = "0x6001520")]
	public void SetBool(string name, bool val) { }

	[Address(RVA = "0x305B430", Offset = "0x305A830", Length = "0xE9")]
	[Token(Token = "0x60014F9")]
	public void SetBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer) { }

	[Address(RVA = "0x305B2E0", Offset = "0x305A6E0", Length = "0xE9")]
	[Token(Token = "0x60014F8")]
	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[Address(RVA = "0x305BD20", Offset = "0x305B120", Length = "0xF1")]
	[Token(Token = "0x6001529")]
	public void SetBuffer(int kernelIndex, string name, GraphicsBuffer buffer) { }

	[Address(RVA = "0x305BC20", Offset = "0x305B020", Length = "0xF1")]
	[Token(Token = "0x6001528")]
	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer) { }

	[Address(RVA = "0x305C100", Offset = "0x305B500", Length = "0xF6")]
	[Token(Token = "0x600152E")]
	public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x305BE20", Offset = "0x305B220", Length = "0xE9")]
	[Token(Token = "0x600152D")]
	public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x305BF10", Offset = "0x305B310", Length = "0xF6")]
	[Token(Token = "0x600152C")]
	public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x305C010", Offset = "0x305B410", Length = "0xE9")]
	[Token(Token = "0x600152B")]
	public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x305C010", Offset = "0x305B410", Length = "0xE9")]
	[FreeFunction(Name = "ComputeShaderScripting::SetConstantBuffer", HasExplicitThis = True)]
	[Token(Token = "0x60014FA")]
	private void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x305C200", Offset = "0x305B600", Length = "0x60")]
	[Token(Token = "0x6001543")]
	private static void SetConstantComputeBuffer_Injected(IntPtr _unity_self, int nameID, IntPtr buffer, int offset, int size) { }

	[Address(RVA = "0x305BE20", Offset = "0x305B220", Length = "0xE9")]
	[FreeFunction(Name = "ComputeShaderScripting::SetConstantBuffer", HasExplicitThis = True)]
	[Token(Token = "0x60014FB")]
	private void SetConstantGraphicsBuffer(int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x305C260", Offset = "0x305B660", Length = "0x60")]
	[Token(Token = "0x6001544")]
	private static void SetConstantGraphicsBuffer_Injected(IntPtr _unity_self, int nameID, IntPtr buffer, int offset, int size) { }

	[Address(RVA = "0x305C310", Offset = "0x305B710", Length = "0x85")]
	[FreeFunction("ComputeShaderScripting::SetEnabledKeywords", HasExplicitThis = True)]
	[Token(Token = "0x6001512")]
	private void SetEnabledKeywords(LocalKeyword[] keywords) { }

	[Address(RVA = "0x305C2C0", Offset = "0x305B6C0", Length = "0x42")]
	[Token(Token = "0x6001555")]
	private static void SetEnabledKeywords_Injected(IntPtr _unity_self, LocalKeyword[] keywords) { }

	[Address(RVA = "0x305C600", Offset = "0x305BA00", Length = "0xA0")]
	[Token(Token = "0x6001516")]
	public void SetFloat(string name, float val) { }

	[Address(RVA = "0x305C560", Offset = "0x305B960", Length = "0x93")]
	[FreeFunction(Name = "ComputeShaderScripting::SetValue<float>", HasExplicitThis = True)]
	[Token(Token = "0x60014E9")]
	public void SetFloat(int nameID, float val) { }

	[Address(RVA = "0x305C510", Offset = "0x305B910", Length = "0x50")]
	[Token(Token = "0x6001535")]
	private static void SetFloat_Injected(IntPtr _unity_self, int nameID, float val) { }

	[Address(RVA = "0x305C3F0", Offset = "0x305B7F0", Length = "0x112")]
	[FreeFunction(Name = "ComputeShaderScripting::SetArray<float>", HasExplicitThis = True)]
	[Token(Token = "0x60014ED")]
	private void SetFloatArray(int nameID, Single[] values) { }

	[Address(RVA = "0x305C3A0", Offset = "0x305B7A0", Length = "0x50")]
	[Token(Token = "0x6001539")]
	private static void SetFloatArray_Injected(IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values) { }

	[Address(RVA = "0x305C6F0", Offset = "0x305BAF0", Length = "0x8")]
	[Token(Token = "0x600151D")]
	public void SetFloats(int nameID, Single[] values) { }

	[Address(RVA = "0x305C6B0", Offset = "0x305BAB0", Length = "0x37")]
	[Token(Token = "0x600151C")]
	public void SetFloats(string name, Single[] values) { }

	[Address(RVA = "0x305C960", Offset = "0x305BD60", Length = "0xA0")]
	[Token(Token = "0x6001517")]
	public void SetInt(string name, int val) { }

	[Address(RVA = "0x305C8C0", Offset = "0x305BCC0", Length = "0x93")]
	[FreeFunction(Name = "ComputeShaderScripting::SetValue<int>", HasExplicitThis = True)]
	[Token(Token = "0x60014EA")]
	public void SetInt(int nameID, int val) { }

	[Address(RVA = "0x305C870", Offset = "0x305BC70", Length = "0x50")]
	[Token(Token = "0x6001536")]
	private static void SetInt_Injected(IntPtr _unity_self, int nameID, int val) { }

	[Address(RVA = "0x305C750", Offset = "0x305BB50", Length = "0x112")]
	[FreeFunction(Name = "ComputeShaderScripting::SetArray<int>", HasExplicitThis = True)]
	[Token(Token = "0x60014EE")]
	private void SetIntArray(int nameID, Int32[] values) { }

	[Address(RVA = "0x305C700", Offset = "0x305BB00", Length = "0x50")]
	[Token(Token = "0x600153A")]
	private static void SetIntArray_Injected(IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values) { }

	[Address(RVA = "0x305CA20", Offset = "0x305BE20", Length = "0x37")]
	[Token(Token = "0x600151E")]
	public void SetInts(string name, Int32[] values) { }

	[Address(RVA = "0x305CA10", Offset = "0x305BE10", Length = "0x8")]
	[Token(Token = "0x600151F")]
	public void SetInts(int nameID, Int32[] values) { }

	[Address(RVA = "0x305CA60", Offset = "0x305BE60", Length = "0x9F")]
	[Token(Token = "0x600150A")]
	public void SetKeyword(in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x305CB60", Offset = "0x305BF60", Length = "0x97")]
	[FreeFunction("ComputeShaderScripting::SetKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001506")]
	private void SetLocalKeyword(LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x305CB00", Offset = "0x305BF00", Length = "0x54")]
	[Token(Token = "0x600154F")]
	private static void SetLocalKeyword_Injected(IntPtr _unity_self, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x305CFA0", Offset = "0x305C3A0", Length = "0x93")]
	[FreeFunction(Name = "ComputeShaderScripting::SetValue<Matrix4x4f>", HasExplicitThis = True)]
	[Token(Token = "0x60014EC")]
	public void SetMatrix(int nameID, Matrix4x4 val) { }

	[Address(RVA = "0x305CEE0", Offset = "0x305C2E0", Length = "0xBB")]
	[Token(Token = "0x6001519")]
	public void SetMatrix(string name, Matrix4x4 val) { }

	[Address(RVA = "0x305CE90", Offset = "0x305C290", Length = "0x50")]
	[Token(Token = "0x6001538")]
	private static void SetMatrix_Injected(IntPtr _unity_self, int nameID, in Matrix4x4 val) { }

	[Address(RVA = "0x305CD70", Offset = "0x305C170", Length = "0x11F")]
	[Token(Token = "0x600151B")]
	public void SetMatrixArray(string name, Matrix4x4[] values) { }

	[Address(RVA = "0x305CC50", Offset = "0x305C050", Length = "0x112")]
	[FreeFunction(Name = "ComputeShaderScripting::SetArray<Matrix4x4f>", HasExplicitThis = True)]
	[Token(Token = "0x60014F0")]
	public void SetMatrixArray(int nameID, Matrix4x4[] values) { }

	[Address(RVA = "0x305CC00", Offset = "0x305C000", Length = "0x50")]
	[Token(Token = "0x600153C")]
	private static void SetMatrixArray_Injected(IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values) { }

	[Address(RVA = "0x305D040", Offset = "0x305C440", Length = "0xF1")]
	[Token(Token = "0x600152A")]
	public void SetRayTracingAccelerationStructure(int kernelIndex, string name, RayTracingAccelerationStructure accelerationStructure) { }

	[Address(RVA = "0x305B580", Offset = "0x305A980", Length = "0xE9")]
	[Token(Token = "0x60014F7")]
	public void SetRayTracingAccelerationStructure(int kernelIndex, int nameID, RayTracingAccelerationStructure accelerationStructure) { }

	[Address(RVA = "0x305D1A0", Offset = "0x305C5A0", Length = "0xF5")]
	[NativeMethod(Name = "ComputeShaderScripting::SetRenderTexture", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x60014F2")]
	private void SetRenderTexture(int kernelIndex, int nameID, RenderTexture texture, int mipLevel, RenderTextureSubElement element) { }

	[Address(RVA = "0x305D140", Offset = "0x305C540", Length = "0x60")]
	[Token(Token = "0x600153E")]
	private static void SetRenderTexture_Injected(IntPtr _unity_self, int kernelIndex, int nameID, IntPtr texture, int mipLevel, RenderTextureSubElement element) { }

	[Address(RVA = "0x305D2F0", Offset = "0x305C6F0", Length = "0x85")]
	[FreeFunction("ComputeShaderScripting::SetShaderKeywords", HasExplicitThis = True)]
	[Token(Token = "0x600150E")]
	private void SetShaderKeywords(String[] names) { }

	[Address(RVA = "0x305D2A0", Offset = "0x305C6A0", Length = "0x42")]
	[Token(Token = "0x6001553")]
	private static void SetShaderKeywords_Injected(IntPtr _unity_self, String[] names) { }

	[Address(RVA = "0x305D5B0", Offset = "0x305C9B0", Length = "0xF5")]
	[NativeMethod(Name = "ComputeShaderScripting::SetTexture", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x60014F1")]
	public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel) { }

	[Address(RVA = "0x305D8C0", Offset = "0x305CCC0", Length = "0xFD")]
	[Token(Token = "0x6001526")]
	public void SetTexture(int kernelIndex, string name, RenderTexture texture, int mipLevel, RenderTextureSubElement element) { }

	[Address(RVA = "0x305D7B0", Offset = "0x305CBB0", Length = "0x101")]
	[Token(Token = "0x6001522")]
	public void SetTexture(int kernelIndex, int nameID, Texture texture) { }

	[Address(RVA = "0x305D9C0", Offset = "0x305CDC0", Length = "0x109")]
	[Token(Token = "0x6001523")]
	public void SetTexture(int kernelIndex, string name, Texture texture) { }

	[Address(RVA = "0x305D6B0", Offset = "0x305CAB0", Length = "0xFD")]
	[Token(Token = "0x6001524")]
	public void SetTexture(int kernelIndex, string name, Texture texture, int mipLevel) { }

	[Address(RVA = "0x305D1A0", Offset = "0x305C5A0", Length = "0xF5")]
	[Token(Token = "0x6001525")]
	public void SetTexture(int kernelIndex, int nameID, RenderTexture texture, int mipLevel, RenderTextureSubElement element) { }

	[Address(RVA = "0x305D550", Offset = "0x305C950", Length = "0x60")]
	[Token(Token = "0x600153D")]
	private static void SetTexture_Injected(IntPtr _unity_self, int kernelIndex, int nameID, IntPtr texture, int mipLevel) { }

	[Address(RVA = "0x305D490", Offset = "0x305C890", Length = "0xBB")]
	[Token(Token = "0x6001527")]
	public void SetTextureFromGlobal(int kernelIndex, string name, string globalTextureName) { }

	[Address(RVA = "0x305D3E0", Offset = "0x305C7E0", Length = "0xA7")]
	[NativeMethod(Name = "ComputeShaderScripting::SetTextureFromGlobal", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x60014F3")]
	public void SetTextureFromGlobal(int kernelIndex, int nameID, int globalTextureNameID) { }

	[Address(RVA = "0x305D380", Offset = "0x305C780", Length = "0x60")]
	[Token(Token = "0x600153F")]
	private static void SetTextureFromGlobal_Injected(IntPtr _unity_self, int kernelIndex, int nameID, int globalTextureNameID) { }

	[Address(RVA = "0x305DDB0", Offset = "0x305D1B0", Length = "0xA0")]
	[Token(Token = "0x6001518")]
	public void SetVector(string name, Vector4 val) { }

	[Address(RVA = "0x305DE60", Offset = "0x305D260", Length = "0x93")]
	[FreeFunction(Name = "ComputeShaderScripting::SetValue<Vector4f>", HasExplicitThis = True)]
	[Token(Token = "0x60014EB")]
	public void SetVector(int nameID, Vector4 val) { }

	[Address(RVA = "0x305DD60", Offset = "0x305D160", Length = "0x50")]
	[Token(Token = "0x6001537")]
	private static void SetVector_Injected(IntPtr _unity_self, int nameID, in Vector4 val) { }

	[Address(RVA = "0x305DB20", Offset = "0x305CF20", Length = "0x112")]
	[FreeFunction(Name = "ComputeShaderScripting::SetArray<Vector4f>", HasExplicitThis = True)]
	[Token(Token = "0x60014EF")]
	public void SetVectorArray(int nameID, Vector4[] values) { }

	[Address(RVA = "0x305DC40", Offset = "0x305D040", Length = "0x11F")]
	[Token(Token = "0x600151A")]
	public void SetVectorArray(string name, Vector4[] values) { }

	[Address(RVA = "0x305DAD0", Offset = "0x305CED0", Length = "0x50")]
	[Token(Token = "0x600153B")]
	private static void SetVectorArray_Injected(IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values) { }

}

