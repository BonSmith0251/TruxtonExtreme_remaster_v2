namespace UnityEngine.Splines;

[Token(Token = "0x2000011")]
public static class InterpolatorUtility
{
	[Token(Token = "0x4000029")]
	private static readonly IInterpolator<Single> s_LerpFloat; //Field offset: 0x0
	[Token(Token = "0x400002A")]
	private static readonly IInterpolator<float2> s_LerpFloat2; //Field offset: 0x8
	[Token(Token = "0x400002B")]
	private static readonly IInterpolator<float3> s_LerpFloat3; //Field offset: 0x10
	[Token(Token = "0x400002C")]
	private static readonly IInterpolator<float4> s_LerpFloat4; //Field offset: 0x18
	[Token(Token = "0x400002D")]
	private static readonly IInterpolator<float2> s_SlerpFloat2; //Field offset: 0x20
	[Token(Token = "0x400002E")]
	private static readonly IInterpolator<float3> s_SlerpFloat3; //Field offset: 0x28
	[Token(Token = "0x400002F")]
	private static readonly IInterpolator<quaternion> s_LerpQuaternion; //Field offset: 0x30
	[Token(Token = "0x4000030")]
	private static readonly IInterpolator<Color> s_LerpColor; //Field offset: 0x38
	[Token(Token = "0x4000031")]
	private static readonly IInterpolator<Single> s_SmoothStepFloat; //Field offset: 0x40
	[Token(Token = "0x4000032")]
	private static readonly IInterpolator<float2> s_SmoothStepFloat2; //Field offset: 0x48
	[Token(Token = "0x4000033")]
	private static readonly IInterpolator<float3> s_SmoothStepFloat3; //Field offset: 0x50
	[Token(Token = "0x4000034")]
	private static readonly IInterpolator<float4> s_SmoothStepFloat4; //Field offset: 0x58
	[Token(Token = "0x4000035")]
	private static readonly IInterpolator<quaternion> s_SlerpQuaternion; //Field offset: 0x60

	[Token(Token = "0x17000012")]
	public static IInterpolator<Color> LerpColor
	{
		[Address(RVA = "0x2E5A170", Offset = "0x2E59570", Length = "0x4F")]
		[Token(Token = "0x6000062")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700000B")]
	public static IInterpolator<Single> LerpFloat
	{
		[Address(RVA = "0x2E5A2B0", Offset = "0x2E596B0", Length = "0x4E")]
		[Token(Token = "0x600005B")]
		 get { } //Length: 78
	}

	[Token(Token = "0x1700000C")]
	public static IInterpolator<float2> LerpFloat2
	{
		[Address(RVA = "0x2E5A1C0", Offset = "0x2E595C0", Length = "0x4F")]
		[Token(Token = "0x600005C")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700000D")]
	public static IInterpolator<float3> LerpFloat3
	{
		[Address(RVA = "0x2E5A210", Offset = "0x2E59610", Length = "0x4F")]
		[Token(Token = "0x600005D")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700000E")]
	public static IInterpolator<float4> LerpFloat4
	{
		[Address(RVA = "0x2E5A260", Offset = "0x2E59660", Length = "0x4F")]
		[Token(Token = "0x600005E")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000011")]
	public static IInterpolator<quaternion> LerpQuaternion
	{
		[Address(RVA = "0x2E5A300", Offset = "0x2E59700", Length = "0x4F")]
		[Token(Token = "0x6000061")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700000F")]
	public static IInterpolator<float2> SlerpFloat2
	{
		[Address(RVA = "0x2E5A350", Offset = "0x2E59750", Length = "0x4F")]
		[Token(Token = "0x600005F")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000010")]
	public static IInterpolator<float3> SlerpFloat3
	{
		[Address(RVA = "0x2E5A3A0", Offset = "0x2E597A0", Length = "0x4F")]
		[Token(Token = "0x6000060")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000017")]
	public static IInterpolator<quaternion> SlerpQuaternion
	{
		[Address(RVA = "0x2E5A3F0", Offset = "0x2E597F0", Length = "0x4F")]
		[Token(Token = "0x6000067")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000013")]
	public static IInterpolator<Single> SmoothStepFloat
	{
		[Address(RVA = "0x2E5A530", Offset = "0x2E59930", Length = "0x4F")]
		[Token(Token = "0x6000063")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000014")]
	public static IInterpolator<float2> SmoothStepFloat2
	{
		[Address(RVA = "0x2E5A440", Offset = "0x2E59840", Length = "0x4F")]
		[Token(Token = "0x6000064")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000015")]
	public static IInterpolator<float3> SmoothStepFloat3
	{
		[Address(RVA = "0x2E5A490", Offset = "0x2E59890", Length = "0x4F")]
		[Token(Token = "0x6000065")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000016")]
	public static IInterpolator<float4> SmoothStepFloat4
	{
		[Address(RVA = "0x2E5A4E0", Offset = "0x2E598E0", Length = "0x4F")]
		[Token(Token = "0x6000066")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x2E59D60", Offset = "0x2E59160", Length = "0x406")]
	[Token(Token = "0x6000068")]
	private static InterpolatorUtility() { }

	[Address(RVA = "0x2E5A170", Offset = "0x2E59570", Length = "0x4F")]
	[Token(Token = "0x6000062")]
	public static IInterpolator<Color> get_LerpColor() { }

	[Address(RVA = "0x2E5A2B0", Offset = "0x2E596B0", Length = "0x4E")]
	[Token(Token = "0x600005B")]
	public static IInterpolator<Single> get_LerpFloat() { }

	[Address(RVA = "0x2E5A1C0", Offset = "0x2E595C0", Length = "0x4F")]
	[Token(Token = "0x600005C")]
	public static IInterpolator<float2> get_LerpFloat2() { }

	[Address(RVA = "0x2E5A210", Offset = "0x2E59610", Length = "0x4F")]
	[Token(Token = "0x600005D")]
	public static IInterpolator<float3> get_LerpFloat3() { }

	[Address(RVA = "0x2E5A260", Offset = "0x2E59660", Length = "0x4F")]
	[Token(Token = "0x600005E")]
	public static IInterpolator<float4> get_LerpFloat4() { }

	[Address(RVA = "0x2E5A300", Offset = "0x2E59700", Length = "0x4F")]
	[Token(Token = "0x6000061")]
	public static IInterpolator<quaternion> get_LerpQuaternion() { }

	[Address(RVA = "0x2E5A350", Offset = "0x2E59750", Length = "0x4F")]
	[Token(Token = "0x600005F")]
	public static IInterpolator<float2> get_SlerpFloat2() { }

	[Address(RVA = "0x2E5A3A0", Offset = "0x2E597A0", Length = "0x4F")]
	[Token(Token = "0x6000060")]
	public static IInterpolator<float3> get_SlerpFloat3() { }

	[Address(RVA = "0x2E5A3F0", Offset = "0x2E597F0", Length = "0x4F")]
	[Token(Token = "0x6000067")]
	public static IInterpolator<quaternion> get_SlerpQuaternion() { }

	[Address(RVA = "0x2E5A530", Offset = "0x2E59930", Length = "0x4F")]
	[Token(Token = "0x6000063")]
	public static IInterpolator<Single> get_SmoothStepFloat() { }

	[Address(RVA = "0x2E5A440", Offset = "0x2E59840", Length = "0x4F")]
	[Token(Token = "0x6000064")]
	public static IInterpolator<float2> get_SmoothStepFloat2() { }

	[Address(RVA = "0x2E5A490", Offset = "0x2E59890", Length = "0x4F")]
	[Token(Token = "0x6000065")]
	public static IInterpolator<float3> get_SmoothStepFloat3() { }

	[Address(RVA = "0x2E5A4E0", Offset = "0x2E598E0", Length = "0x4F")]
	[Token(Token = "0x6000066")]
	public static IInterpolator<float4> get_SmoothStepFloat4() { }

}

