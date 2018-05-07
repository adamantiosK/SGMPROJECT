using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour {

    #region Instance Variables

    private bool _gameOn1 = false;
    public bool _gameOn2 = false;
    private bool _first1 = true;
    private bool _first2 = true;
    private bool _done = false;

    #endregion

    #region Instance properties
    public void setEverythingBack()
    {
        _gameOn1 = true;
        _gameOn2 = true;
        _first1 = true;
        _first2 = true;
        _done = false;

    }

    public bool GameOn1
    {
        get
        {
            return _gameOn1;
        }

        set
        {
            _gameOn1 = value;
        }
    }
    public bool GameOn2
              {
        get
        {
            return _gameOn2;
        }

        set
        {
            _gameOn2 = value;
        }
    }
    public bool First1
    {
        get
        {
            return _first1;
        }

        set
        {
            _first1 = value;
        }
    }
    public bool First2
    {
        get
        {
            return _first2;
        }

        set
        {
            _first2 = value;
        }
    }
    public bool Done
    {
        get
        {
            return _done;
        }
        set
        {
            _done = value;
        }
    }
    #endregion
}

