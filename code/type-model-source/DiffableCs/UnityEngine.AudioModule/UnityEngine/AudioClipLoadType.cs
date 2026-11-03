namespace UnityEngine;

[Token(Token = "0x2000005")]
public enum AudioClipLoadType : int
{
	DecompressOnLoad = 0,
	CompressedInMemory = 1,
	Streaming = 2,
}

