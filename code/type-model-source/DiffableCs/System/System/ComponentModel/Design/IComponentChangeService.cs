namespace System.ComponentModel.Design;

[Token(Token = "0x20001C7")]
public interface IComponentChangeService
{

	[Token(Token = "0x6000B75")]
	public void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue) { }

	[Token(Token = "0x6000B76")]
	public void OnComponentChanging(object component, MemberDescriptor member) { }

}

