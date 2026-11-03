namespace UnityEngine.Playables;

[RequiredByNativeCode]
[Token(Token = "0x2000317")]
public interface INotificationReceiver
{

	[RequiredByNativeCode]
	[Token(Token = "0x60018F4")]
	public void OnNotify(Playable origin, INotification notification, object context) { }

}

