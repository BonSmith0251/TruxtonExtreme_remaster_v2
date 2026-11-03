namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x200005D")]
public enum SceneReleaseMode : int
{
	ReleaseSceneWhenSceneUnloaded = 0,
	OnlyReleaseSceneOnHandleRelease = 1,
}

