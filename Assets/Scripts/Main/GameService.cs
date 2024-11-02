using ServiceLocator.Events;
using ServiceLocator.Map;
using ServiceLocator.Player;
using ServiceLocator.Sound;
using ServiceLocator.UI;
using ServiceLocator.Wave;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameService : GenericMonoSingleton<GameService>
{
    // Services:
    public MapService MapService { get; private set; }
    public EventService EventService { get; private set; }
    public WaveService WaveService { get; private set; }
    public SoundService SoundService { get; private set; }
    public PlayerService PlayerService {  get; private set; }


    [SerializeField] private UIService uIService;
    public UIService UIService => uIService;

    // Scriptable Objects:
    [SerializeField] private MapScriptableObject mapScriptableObject;
    [SerializeField] private WaveScriptableObject waveScriptableObject;
    [SerializeField] private SoundScriptableObject soundScriptableObject;
    [SerializeField] private PlayerScriptableObject playerScriptableObject;

    // Scene Referneces:
    [SerializeField] private AudioSource SFXSource;
    [SerializeField] private AudioSource BGSource;

    private void Start()
    {
        EventService = new EventService();
        UIService.SubscribeToEvents();
        MapService = new MapService(mapScriptableObject);
        WaveService = new WaveService(waveScriptableObject);
        SoundService = new SoundService(soundScriptableObject, SFXSource, BGSource);
        PlayerService = new PlayerService(playerScriptableObject);
    }

    private void Update()
    {
        PlayerService.Update();
        // No sound service update logic
    }
}
