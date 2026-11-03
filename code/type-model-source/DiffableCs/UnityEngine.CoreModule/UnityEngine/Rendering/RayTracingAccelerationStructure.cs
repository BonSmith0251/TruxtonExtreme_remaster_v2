namespace UnityEngine.Rendering;

[MovedFrom("UnityEngine.Experimental.Rendering")]
[Token(Token = "0x2000384")]
public sealed class RayTracingAccelerationStructure : IDisposable
{
	[Token(Token = "0x2000389")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6001A82")]
		public static IntPtr ConvertToNative(RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	}

	[Token(Token = "0x2000387")]
	internal struct BuildSettings
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA4")]
		private RayTracingAccelerationStructureBuildFlags <buildFlags>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000AA5")]
		private Vector3 <relativeOrigin>k__BackingField; //Field offset: 0x4

		[Token(Token = "0x170003E0")]
		public RayTracingAccelerationStructureBuildFlags buildFlags
		{
			[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
			[CompilerGenerated]
			[Token(Token = "0x6001A7B")]
			 set { } //Length: 3
		}

		[Token(Token = "0x170003E1")]
		public Vector3 relativeOrigin
		{
			[Address(RVA = "0x29B4BA0", Offset = "0x29B3FA0", Length = "0x10")]
			[CompilerGenerated]
			[Token(Token = "0x6001A7C")]
			 set { } //Length: 16
		}

		[Address(RVA = "0x3099660", Offset = "0x3098A60", Length = "0x4E")]
		[Token(Token = "0x6001A7D")]
		public BuildSettings() { }

		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x6001A7B")]
		public void set_buildFlags(RayTracingAccelerationStructureBuildFlags value) { }

		[Address(RVA = "0x29B4BA0", Offset = "0x29B3FA0", Length = "0x10")]
		[CompilerGenerated]
		[Token(Token = "0x6001A7C")]
		public void set_relativeOrigin(Vector3 value) { }

	}

	[Token(Token = "0x2000386")]
	internal enum ManagementMode : int
	{
		Manual = 0,
		Automatic = 1,
	}

	[Flags]
	[Token(Token = "0x2000385")]
	internal enum RayTracingModeMask : int
	{
		Nothing = 0,
		Static = 2,
		DynamicTransform = 4,
		DynamicGeometry = 8,
		DynamicGeometryManualUpdate = 16,
		Everything = 30,
	}

	[Token(Token = "0x2000388")]
	internal struct Settings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA6")]
		public ManagementMode managementMode; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000AA7")]
		public RayTracingModeMask rayTracingModeMask; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AA8")]
		public int layerMask; //Field offset: 0x8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000AA9")]
		private RayTracingAccelerationStructureBuildFlags <buildFlagsStaticGeometries>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AAA")]
		private RayTracingAccelerationStructureBuildFlags <buildFlagsDynamicGeometries>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000AAB")]
		private bool <enableCompaction>k__BackingField; //Field offset: 0x14

		[Token(Token = "0x170003E3")]
		public RayTracingAccelerationStructureBuildFlags buildFlagsDynamicGeometries
		{
			[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001A7F")]
			 set { } //Length: 4
		}

		[Token(Token = "0x170003E2")]
		public RayTracingAccelerationStructureBuildFlags buildFlagsStaticGeometries
		{
			[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001A7E")]
			 set { } //Length: 4
		}

		[Token(Token = "0x170003E4")]
		public bool enableCompaction
		{
			[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001A80")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x30B70B0", Offset = "0x30B64B0", Length = "0x27")]
		[Token(Token = "0x6001A81")]
		public Settings() { }

		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A7F")]
		public void set_buildFlagsDynamicGeometries(RayTracingAccelerationStructureBuildFlags value) { }

		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A7E")]
		public void set_buildFlagsStaticGeometries(RayTracingAccelerationStructureBuildFlags value) { }

		[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A80")]
		public void set_enableCompaction(bool value) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A99")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x30B6D90", Offset = "0x30B6190", Length = "0x5F")]
	[Token(Token = "0x6001A65")]
	public RayTracingAccelerationStructure(Settings settings) { }

	[Address(RVA = "0x30B6210", Offset = "0x30B5610", Length = "0x42D")]
	[Token(Token = "0x6001A66")]
	public int AddInstance(in RayTracingMeshInstanceConfig config, Matrix4x4 matrix, Nullable<Matrix4x4> prevMatrix = null, uint id = 4294967295) { }

	[Address(RVA = "0x30B66B0", Offset = "0x30B5AB0", Length = "0x81")]
	[FreeFunction("RayTracingAccelerationStructure_Bindings::AddMeshInstance", HasExplicitThis = True)]
	[Token(Token = "0x6001A72")]
	private int AddMeshInstance(RayTracingMeshInstanceConfig config, Matrix4x4 matrix, Matrix4x4* prevMatrix, uint id = 4294967295) { }

	[Address(RVA = "0x30B6640", Offset = "0x30B5A40", Length = "0x62")]
	[Token(Token = "0x6001A7A")]
	private static int AddMeshInstance_Injected(IntPtr _unity_self, in RayTracingMeshInstanceConfig config, in Matrix4x4 matrix, Matrix4x4* prevMatrix, uint id) { }

	[Address(RVA = "0x30B6780", Offset = "0x30B5B80", Length = "0x51")]
	[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::ClearInstances", HasExplicitThis = True)]
	[Token(Token = "0x6001A6B")]
	public void ClearInstances() { }

	[Address(RVA = "0x30B6740", Offset = "0x30B5B40", Length = "0x33")]
	[Token(Token = "0x6001A73")]
	private static void ClearInstances_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30B6820", Offset = "0x30B5C20", Length = "0x33")]
	[FreeFunction("RayTracingAccelerationStructure_Bindings::Create")]
	[Token(Token = "0x6001A6C")]
	private static IntPtr Create(Settings desc) { }

	[Address(RVA = "0x30B67E0", Offset = "0x30B5BE0", Length = "0x33")]
	[Token(Token = "0x6001A74")]
	private static IntPtr Create_Injected(in Settings desc) { }

	[Address(RVA = "0x30B68A0", Offset = "0x30B5CA0", Length = "0x3D")]
	[FreeFunction("RayTracingAccelerationStructure_Bindings::Destroy")]
	[Token(Token = "0x6001A6D")]
	private static void Destroy(RayTracingAccelerationStructure accelStruct) { }

	[Address(RVA = "0x30B6860", Offset = "0x30B5C60", Length = "0x33")]
	[Token(Token = "0x6001A75")]
	private static void Destroy_Injected(IntPtr accelStruct) { }

	[Address(RVA = "0x30B6950", Offset = "0x30B5D50", Length = "0x8B")]
	[Token(Token = "0x6001A63")]
	public override void Dispose() { }

	[Address(RVA = "0x30B68E0", Offset = "0x30B5CE0", Length = "0x64")]
	[Token(Token = "0x6001A64")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x30B69E0", Offset = "0x30B5DE0", Length = "0x3A")]
	[Token(Token = "0x6001A62")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x30B6A60", Offset = "0x30B5E60", Length = "0x58")]
	[Token(Token = "0x6001A67")]
	public void RemoveInstance(int handle) { }

	[Address(RVA = "0x30B6A60", Offset = "0x30B5E60", Length = "0x58")]
	[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::RemoveInstance", HasExplicitThis = True)]
	[Token(Token = "0x6001A6E")]
	private void RemoveInstance_InstanceID(int instanceID) { }

	[Address(RVA = "0x30B6A20", Offset = "0x30B5E20", Length = "0x40")]
	[Token(Token = "0x6001A76")]
	private static void RemoveInstance_InstanceID_Injected(IntPtr _unity_self, int instanceID) { }

	[Address(RVA = "0x30B6B10", Offset = "0x30B5F10", Length = "0x67")]
	[Token(Token = "0x6001A69")]
	public void UpdateInstanceID(int handle, uint instanceID) { }

	[Address(RVA = "0x30B6B10", Offset = "0x30B5F10", Length = "0x67")]
	[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::UpdateInstanceID", HasExplicitThis = True)]
	[Token(Token = "0x6001A71")]
	private void UpdateInstanceID_Handle(int handle, uint id) { }

	[Address(RVA = "0x30B6AC0", Offset = "0x30B5EC0", Length = "0x50")]
	[Token(Token = "0x6001A79")]
	private static void UpdateInstanceID_Handle_Injected(IntPtr _unity_self, int handle, uint id) { }

	[Address(RVA = "0x30B6BD0", Offset = "0x30B5FD0", Length = "0x67")]
	[Token(Token = "0x6001A6A")]
	public void UpdateInstanceMask(int handle, uint mask) { }

	[Address(RVA = "0x30B6BD0", Offset = "0x30B5FD0", Length = "0x67")]
	[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::UpdateInstanceMask", HasExplicitThis = True)]
	[Token(Token = "0x6001A70")]
	private void UpdateInstanceMask_Handle(int handle, uint mask) { }

	[Address(RVA = "0x30B6B80", Offset = "0x30B5F80", Length = "0x50")]
	[Token(Token = "0x6001A78")]
	private static void UpdateInstanceMask_Handle_Injected(IntPtr _unity_self, int handle, uint mask) { }

	[Address(RVA = "0x30B6D00", Offset = "0x30B6100", Length = "0x84")]
	[Token(Token = "0x6001A68")]
	public void UpdateInstanceTransform(int handle, Matrix4x4 matrix) { }

	[Address(RVA = "0x30B6C90", Offset = "0x30B6090", Length = "0x67")]
	[FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::UpdateInstanceTransform", HasExplicitThis = True)]
	[Token(Token = "0x6001A6F")]
	private void UpdateInstanceTransform_Handle(int handle, Matrix4x4 matrix) { }

	[Address(RVA = "0x30B6C40", Offset = "0x30B6040", Length = "0x50")]
	[Token(Token = "0x6001A77")]
	private static void UpdateInstanceTransform_Handle_Injected(IntPtr _unity_self, int handle, in Matrix4x4 matrix) { }

}

