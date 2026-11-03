namespace UnityEngine.UIElements;

[Token(Token = "0x20002FD")]
public interface ICustomStyle
{

	[Token(Token = "0x6001567")]
	public bool TryGetValue(CustomStyleProperty<Single> property, out float value) { }

	[Token(Token = "0x6001568")]
	public bool TryGetValue(CustomStyleProperty<Int32> property, out int value) { }

	[Token(Token = "0x6001569")]
	public bool TryGetValue(CustomStyleProperty<Color> property, out Color value) { }

	[Token(Token = "0x600156A")]
	public bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value) { }

	[Token(Token = "0x600156B")]
	public bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value) { }

	[Token(Token = "0x600156C")]
	public bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value) { }

	[Token(Token = "0x600156D")]
	public bool TryGetValue(CustomStyleProperty<String> property, out string value) { }

}

