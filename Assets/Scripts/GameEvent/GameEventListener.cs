using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] private GameEvent _gameEvent;
    [SerializeField] private UnityEvent _response;
<<<<<<< HEAD
    
=======

    // Start is called before the first frame update
>>>>>>> features_UI
    void OnEnable()
    {
        _gameEvent.RegisterListener(this);
    }
<<<<<<< HEAD
    
=======

    // Update is called once per frame
>>>>>>> features_UI
    void OnDisable()
    {
        _gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised()
    {
        _response.Invoke();
    }
}
