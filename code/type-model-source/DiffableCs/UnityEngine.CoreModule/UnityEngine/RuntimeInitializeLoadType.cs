namespace UnityEngine;

[Token(Token = "0x20001BA")]
public enum RuntimeInitializeLoadType : int
{
	AfterSceneLoad = 0,
	BeforeSceneLoad = 1,
	AfterAssembliesLoaded = 2,
	BeforeSplashScreen = 3,
	SubsystemRegistration = 4,
}

