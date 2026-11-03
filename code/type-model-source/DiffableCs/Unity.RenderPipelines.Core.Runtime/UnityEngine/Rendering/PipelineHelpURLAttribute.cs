namespace UnityEngine.Rendering;

[AttributeUsage(20, AllowMultiple = True)]
[Conditional("UNITY_EDITOR")]
[Token(Token = "0x20000EB")]
public class PipelineHelpURLAttribute : HelpURLAttribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002FD")]
	private readonly string <pipelineName>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002FE")]
	private readonly string <pageName>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002FF")]
	private readonly string <pageHash>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x170000EA")]
	private string pageHash
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000856")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170000E9")]
	private string pageName
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000855")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170000E8")]
	private string pipelineName
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000854")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170000EB")]
	public virtual string URL
	{
		[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
		[Token(Token = "0x6000858")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x2C0DFD0", Offset = "0x2C0D3D0", Length = "0x6E")]
	[Token(Token = "0x6000857")]
	public PipelineHelpURLAttribute(string pipelineName, string pageName, string pageHash = "") { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000856")]
	private string get_pageHash() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000855")]
	private string get_pageName() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000854")]
	private string get_pipelineName() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000858")]
	public virtual string get_URL() { }

}

