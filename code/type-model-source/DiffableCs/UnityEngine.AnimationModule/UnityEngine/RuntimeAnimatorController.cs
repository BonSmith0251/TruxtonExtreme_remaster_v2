namespace UnityEngine;

[ExcludeFromObjectFactory]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
[Token(Token = "0x2000027")]
[UsedByNativeCode]
public class RuntimeAnimatorController : object
{

	[Token(Token = "0x17000051")]
	public AnimationClip[] animationClips
	{
		[Address(RVA = "0x2FC2240", Offset = "0x2FC1640", Length = "0x215")]
		[Token(Token = "0x6000220")]
		 get { } //Length: 533
	}

	[Address(RVA = "0x2FC21B0", Offset = "0x2FC15B0", Length = "0x49")]
	[Token(Token = "0x600021F")]
	protected RuntimeAnimatorController() { }

	[Address(RVA = "0x2FC2240", Offset = "0x2FC1640", Length = "0x215")]
	[Token(Token = "0x6000220")]
	public AnimationClip[] get_animationClips() { }

	[Address(RVA = "0x2FC2200", Offset = "0x2FC1600", Length = "0x33")]
	[Token(Token = "0x6000221")]
	private static AnimationClip[] get_animationClips_Injected(IntPtr _unity_self) { }

}

