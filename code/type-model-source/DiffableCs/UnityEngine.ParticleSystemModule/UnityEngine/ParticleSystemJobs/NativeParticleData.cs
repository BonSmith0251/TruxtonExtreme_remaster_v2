namespace UnityEngine.ParticleSystemJobs;

[Token(Token = "0x2000040")]
internal struct NativeParticleData
{
	[Token(Token = "0x2000041")]
	public struct Array3
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000125")]
		internal Single* x; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000126")]
		internal Single* y; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000127")]
		internal Single* z; //Field offset: 0x10

	}

	[Token(Token = "0x2000042")]
	public struct Array4
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000128")]
		internal Single* x; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000129")]
		internal Single* y; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012A")]
		internal Single* z; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400012B")]
		internal Single* w; //Field offset: 0x18

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000117")]
	internal int count; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000118")]
	internal Array3 positions; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000119")]
	internal Array3 velocities; //Field offset: 0x20
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400011A")]
	internal Array3 axisOfRotations; //Field offset: 0x38
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400011B")]
	internal Array3 rotations; //Field offset: 0x50
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400011C")]
	internal Array3 rotationalSpeeds; //Field offset: 0x68
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400011D")]
	internal Array3 sizes; //Field offset: 0x80
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400011E")]
	internal Void* startColors; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400011F")]
	internal Void* aliveTimePercent; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000120")]
	internal Void* inverseStartLifetimes; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000121")]
	internal Void* randomSeeds; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000122")]
	internal Array4 customData1; //Field offset: 0xB8
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000123")]
	internal Array4 customData2; //Field offset: 0xD8
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000124")]
	internal Void* meshIndices; //Field offset: 0xF8

}

