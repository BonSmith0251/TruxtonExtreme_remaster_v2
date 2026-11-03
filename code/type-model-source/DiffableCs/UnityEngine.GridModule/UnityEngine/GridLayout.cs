namespace UnityEngine;

[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeType(Header = "Modules/Grid/Public/Grid.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000002")]
public class GridLayout : Behaviour
{

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000001")]
	private void DoNothing() { }

}

