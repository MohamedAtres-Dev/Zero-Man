using UnityEngine;
using Zenject;

public class TestInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IAudioManager>().To<AudioManager>().AsSingle();
    }
}