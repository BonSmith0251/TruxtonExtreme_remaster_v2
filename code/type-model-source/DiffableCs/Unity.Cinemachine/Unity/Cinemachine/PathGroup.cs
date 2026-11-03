namespace Unity.Cinemachine;

[Token(Token = "0x200018C")]
internal class PathGroup
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000690")]
	internal List<List`1<Point64>> _inPaths; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000691")]
	internal List<Point64> _outPath; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000692")]
	internal List<List`1<Point64>> _outPaths; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000693")]
	internal JoinType _joinType; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000694")]
	internal EndType _endType; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000695")]
	internal bool _pathsReversed; //Field offset: 0x30

	[Address(RVA = "0x28A4FA0", Offset = "0x28A43A0", Length = "0x12E")]
	[Token(Token = "0x600082D")]
	public PathGroup(List<List`1<Point64>> paths, JoinType joinType, EndType endType = 0) { }

}

