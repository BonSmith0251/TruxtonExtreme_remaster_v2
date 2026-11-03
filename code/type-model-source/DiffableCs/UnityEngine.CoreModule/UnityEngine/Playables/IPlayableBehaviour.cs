namespace UnityEngine.Playables;

[Token(Token = "0x2000319")]
public interface IPlayableBehaviour
{

	[RequiredByNativeCode]
	[Token(Token = "0x60018FB")]
	public void OnBehaviourPause(Playable playable, FrameData info) { }

	[RequiredByNativeCode]
	[Token(Token = "0x60018FA")]
	public void OnBehaviourPlay(Playable playable, FrameData info) { }

	[RequiredByNativeCode]
	[Token(Token = "0x60018F6")]
	public void OnGraphStart(Playable playable) { }

	[RequiredByNativeCode]
	[Token(Token = "0x60018F7")]
	public void OnGraphStop(Playable playable) { }

	[RequiredByNativeCode]
	[Token(Token = "0x60018F8")]
	public void OnPlayableCreate(Playable playable) { }

	[RequiredByNativeCode]
	[Token(Token = "0x60018F9")]
	public void OnPlayableDestroy(Playable playable) { }

	[RequiredByNativeCode]
	[Token(Token = "0x60018FC")]
	public void PrepareFrame(Playable playable, FrameData info) { }

	[RequiredByNativeCode]
	[Token(Token = "0x60018FD")]
	public void ProcessFrame(Playable playable, FrameData info, object playerData) { }

}

