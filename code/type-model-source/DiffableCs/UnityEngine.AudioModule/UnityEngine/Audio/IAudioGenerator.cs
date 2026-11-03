namespace UnityEngine.Audio;

[Token(Token = "0x200001F")]
[UsedByNativeCode]
public interface IAudioGenerator : ICapabilities
{

	[Token(Token = "0x6000099")]
	public GeneratorInstance CreateInstance(ControlContext context, Nullable<AudioFormat> nestedFormat, CreationParameters creationParameters) { }

}

