using RotaryHeart.Lib.SerializableDictionary;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
namespace HybridCLR.Editor
{
    [FilePath("ProjectSettings/HybridCLRSettings.asset")]
    public class HybridCLRSettings : ScriptableSingleton<HybridCLRSettings>
    {
        [Header("开启HybridCLR插件")]
        public bool enable = true;

        [Header("使用全局安装的il2cpp")]
        public bool useGlobalIl2cpp;

        [Header("hybridclr 仓库 URL")]
        public string hybridclrRepoURL = "https://gitee.com/focus-creative-games/hybridclr";

        [Header("il2cpp_plus 仓库 URL")]
        public string il2cppPlusRepoURL = "https://gitee.com/focus-creative-games/il2cpp_plus";

        [Header("热更新dll编译输出根目录")]
        public string hotUpdateDllCompileOutputRootDir = "HybridCLRData/HotUpdateDlls";

        [Header("裁减后AOT dll输出根目录")]
        public string strippedAOTDllOutputRootDir = "HybridCLRData/AssembliesPostIl2CppStrip";

        [Header("热更新Assembly Definitions")]
        public StringAssemblyDefinitionAssetDic hotUpdateAssemblyDefinitions;

        [Header("热更新dlls")]
        public StringStringListDic hotUpdateAssemblies;

        [Header("预留的热更新dlls")]
        public StringStringListDic preserveHotUpdateAssemblies;

        [Header("外部热更新dll搜索路径")]
        public StringStringListDic externalHotUpdateAssembliyDirs;

        [Header("补充元数据AOT dlls")]
        public string[] patchAOTAssemblies;

        [Header("生成link.xml时扫描asset中引用的类型")]
        public bool collectAssetReferenceTypes;

        [Header("生成的link.xml路径")]
        public string outputLinkFile = "HybridCLRData/Generated/link.xml";

        [Header("自动扫描生成的AOTGenericReferences.cs路径")]
        public string outputAOTGenericReferenceFile = "HybridCLRData/Generated/AOTGenericReferences.cs";

        [Header("AOT泛型实例化搜索迭代次数")]
        public int maxGenericReferenceIteration = 10;

        [Header("MethodBridge泛型搜索迭代次数")]
        public int maxMethodBridgeGenericIteration = 10;
    }

    [System.Serializable]
    public class StringStringListDic : SerializableDictionaryBase<string, StringList>
    {

    }

    [System.Serializable]
    public class StringList
    {
        public List<string> list;
    }

    [System.Serializable]
    public class StringAssemblyDefinitionAssetDic : SerializableDictionaryBase<string, AssemblyDefinitionAssetList>
    {

    }

    [System.Serializable]
    public class AssemblyDefinitionAssetList
    {
        public List<AssemblyDefinitionAsset> list;
    }
}
