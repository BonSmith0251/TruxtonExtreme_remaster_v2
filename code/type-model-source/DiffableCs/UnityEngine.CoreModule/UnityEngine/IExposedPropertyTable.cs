namespace UnityEngine;

[Token(Token = "0x20000BB")]
public interface IExposedPropertyTable
{

	[Token(Token = "0x6000538")]
	public object GetReferenceValue(PropertyName id, out bool idValid) { }

}

