namespace UnityEngine;

[Token(Token = "0x2000004")]
public struct AudioConfiguration
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000F")]
	public AudioSpeakerMode speakerMode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000010")]
	public int dspBufferSize; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000011")]
	public int sampleRate; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000012")]
	public int numRealVoices; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000013")]
	public int numVirtualVoices; //Field offset: 0x10

}

