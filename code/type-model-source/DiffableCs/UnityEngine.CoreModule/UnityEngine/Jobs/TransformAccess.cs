namespace UnityEngine.Jobs;

[NativeHeader("Runtime/Transform/ScriptBindings/TransformAccess.bindings.h")]
[Token(Token = "0x200020B")]
public struct TransformAccess
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400073E")]
	private IntPtr hierarchy; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400073F")]
	private int index; //Field offset: 0x8

	[Token(Token = "0x1700037B")]
	public bool isValid
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[Token(Token = "0x6001731")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000377")]
	public Vector3 localPosition
	{
		[Address(RVA = "0x308D4C0", Offset = "0x308C8C0", Length = "0x42")]
		[Token(Token = "0x600172C")]
		 set { } //Length: 66
	}

	[Token(Token = "0x17000378")]
	public Quaternion localRotation
	{
		[Address(RVA = "0x308D280", Offset = "0x308C680", Length = "0x5D")]
		[Token(Token = "0x600172D")]
		 get { } //Length: 93
		[Address(RVA = "0x308D510", Offset = "0x308C910", Length = "0x42")]
		[Token(Token = "0x600172E")]
		 set { } //Length: 66
	}

	[Token(Token = "0x17000379")]
	public Vector3 localScale
	{
		[Address(RVA = "0x308D2E0", Offset = "0x308C6E0", Length = "0x69")]
		[Token(Token = "0x600172F")]
		 get { } //Length: 105
	}

	[Token(Token = "0x1700037A")]
	public Matrix4x4 localToWorldMatrix
	{
		[Address(RVA = "0x308D350", Offset = "0x308C750", Length = "0x93")]
		[Token(Token = "0x6001730")]
		 get { } //Length: 147
	}

	[Token(Token = "0x17000375")]
	public Vector3 position
	{
		[Address(RVA = "0x308D3F0", Offset = "0x308C7F0", Length = "0x69")]
		[Token(Token = "0x600172A")]
		 get { } //Length: 105
	}

	[Token(Token = "0x17000376")]
	public Quaternion rotation
	{
		[Address(RVA = "0x308D460", Offset = "0x308C860", Length = "0x5D")]
		[Token(Token = "0x600172B")]
		 get { } //Length: 93
	}

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[Token(Token = "0x6001731")]
	public bool get_isValid() { }

	[Address(RVA = "0x308D280", Offset = "0x308C680", Length = "0x5D")]
	[Token(Token = "0x600172D")]
	public Quaternion get_localRotation() { }

	[Address(RVA = "0x308D2E0", Offset = "0x308C6E0", Length = "0x69")]
	[Token(Token = "0x600172F")]
	public Vector3 get_localScale() { }

	[Address(RVA = "0x308D350", Offset = "0x308C750", Length = "0x93")]
	[Token(Token = "0x6001730")]
	public Matrix4x4 get_localToWorldMatrix() { }

	[Address(RVA = "0x308D3F0", Offset = "0x308C7F0", Length = "0x69")]
	[Token(Token = "0x600172A")]
	public Vector3 get_position() { }

	[Address(RVA = "0x308D460", Offset = "0x308C860", Length = "0x5D")]
	[Token(Token = "0x600172B")]
	public Quaternion get_rotation() { }

	[Address(RVA = "0x308CED0", Offset = "0x308C2D0", Length = "0x42")]
	[NativeMethod(Name = "TransformAccessBindings::GetLocalRotation", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x6001739")]
	private static void GetLocalRotation(ref TransformAccess access, out Quaternion r) { }

	[Address(RVA = "0x308CF20", Offset = "0x308C320", Length = "0x42")]
	[NativeMethod(Name = "TransformAccessBindings::GetLocalScale", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x600173B")]
	private static void GetLocalScale(ref TransformAccess access, out Vector3 r) { }

	[Address(RVA = "0x308CF70", Offset = "0x308C370", Length = "0x42")]
	[NativeMethod(Name = "TransformAccessBindings::GetLocalToWorldMatrix", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x600173C")]
	private static void GetLocalToWorldMatrix(ref TransformAccess access, out Matrix4x4 m) { }

	[Address(RVA = "0x308CFC0", Offset = "0x308C3C0", Length = "0x42")]
	[NativeMethod(Name = "TransformAccessBindings::GetPosition", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x6001736")]
	private static void GetPosition(ref TransformAccess access, out Vector3 p) { }

	[Address(RVA = "0x308D010", Offset = "0x308C410", Length = "0x42")]
	[NativeMethod(Name = "TransformAccessBindings::GetRotation", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x6001737")]
	private static void GetRotation(ref TransformAccess access, out Quaternion r) { }

	[Address(RVA = "0x308D4C0", Offset = "0x308C8C0", Length = "0x42")]
	[Token(Token = "0x600172C")]
	public void set_localPosition(Vector3 value) { }

	[Address(RVA = "0x308D510", Offset = "0x308C910", Length = "0x42")]
	[Token(Token = "0x600172E")]
	public void set_localRotation(Quaternion value) { }

	[Address(RVA = "0x308D120", Offset = "0x308C520", Length = "0x42")]
	[NativeMethod(Name = "TransformAccessBindings::SetLocalPosition", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x6001738")]
	private static void SetLocalPosition(ref TransformAccess access, ref Vector3 p) { }

	[Address(RVA = "0x308D0C0", Offset = "0x308C4C0", Length = "0x52")]
	[Token(Token = "0x6001733")]
	public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation) { }

	[Address(RVA = "0x308D060", Offset = "0x308C460", Length = "0x52")]
	[NativeMethod(Name = "TransformAccessBindings::SetLocalPositionAndRotation", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x6001735")]
	private static void SetLocalPositionAndRotation_Internal(ref TransformAccess access, ref Vector3 localPosition, ref Quaternion localRotation) { }

	[Address(RVA = "0x308D170", Offset = "0x308C570", Length = "0x42")]
	[NativeMethod(Name = "TransformAccessBindings::SetLocalRotation", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x600173A")]
	private static void SetLocalRotation(ref TransformAccess access, ref Quaternion r) { }

	[Address(RVA = "0x308D220", Offset = "0x308C620", Length = "0x52")]
	[Token(Token = "0x6001732")]
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	[Address(RVA = "0x308D1C0", Offset = "0x308C5C0", Length = "0x52")]
	[NativeMethod(Name = "TransformAccessBindings::SetPositionAndRotation", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x6001734")]
	private static void SetPositionAndRotation_Internal(ref TransformAccess access, ref Vector3 position, ref Quaternion rotation) { }

}

