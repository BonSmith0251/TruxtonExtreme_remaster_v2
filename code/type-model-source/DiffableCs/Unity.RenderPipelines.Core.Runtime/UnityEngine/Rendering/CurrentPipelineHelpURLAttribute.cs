namespace UnityEngine.Rendering;

[AttributeUsage(20, AllowMultiple = False)]
[Conditional("UNITY_EDITOR")]
[Token(Token = "0x20000EA")]
public class CurrentPipelineHelpURLAttribute : HelpURLAttribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002FB")]
	private readonly string <pageName>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002FC")]
	private readonly string <pageHash>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x170000E6")]
	private string pageHash
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000851")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170000E5")]
	private string pageName
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000850")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170000E7")]
	public virtual string URL
	{
		[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
		[Token(Token = "0x6000853")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x2C0CE60", Offset = "0x2C0C260", Length = "0x51")]
	[Token(Token = "0x6000852")]
	public CurrentPipelineHelpURLAttribute(string pageName, string pageHash = "") { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000851")]
	private string get_pageHash() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000850")]
	private string get_pageName() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000853")]
	public virtual string get_URL() { }

}

