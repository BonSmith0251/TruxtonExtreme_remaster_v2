using UnityEditor;
using UnityEngine;

// Import settings for the original sounds in Resources/TruxtonAudio (written by the truxton-sound skill).
// Music and comic/village tracks stream or stay compressed and load on demand; effects decompress on load so they
// start without decode latency. All stay Vorbis at the original 48 kHz.
public sealed class TruxtonAudioImport : AssetPostprocessor
{
    const string Root="Assets/Resources/TruxtonAudio/";
    void OnPreprocessAudio()
    {
        if(!assetPath.StartsWith(Root))return;
        var importer=(AudioImporter)assetImporter;
        string group=assetPath.Substring(Root.Length).Split('/')[0];
        var settings=importer.defaultSampleSettings;
        settings.compressionFormat=AudioCompressionFormat.Vorbis;settings.quality=.7f;
        settings.sampleRateSetting=AudioSampleRateSetting.PreserveSampleRate;
        if(group=="SE"){settings.loadType=AudioClipLoadType.DecompressOnLoad;settings.preloadAudioData=true;}
        else if(group=="BGM"){settings.loadType=AudioClipLoadType.Streaming;settings.preloadAudioData=false;}
        else {settings.loadType=AudioClipLoadType.CompressedInMemory;settings.preloadAudioData=false;}
        importer.defaultSampleSettings=settings;importer.forceToMono=false;importer.loadInBackground=group!="SE";
    }
}
