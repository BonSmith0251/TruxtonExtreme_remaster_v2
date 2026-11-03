namespace UnityEngine.Rendering;

[Token(Token = "0x200034F")]
public enum LightEvent : int
{
	BeforeShadowMap = 0,
	AfterShadowMap = 1,
	BeforeScreenspaceMask = 2,
	AfterScreenspaceMask = 3,
	BeforeShadowMapPass = 4,
	AfterShadowMapPass = 5,
}

