using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRight : MonoBehaviour {


    #region Instance Variables

    [SerializeField]
    private int _lives = 7;
    [SerializeField]
    private GameObject _part7;
    [SerializeField]
    private GameObject _part6;
    [SerializeField]
    private GameObject _part5;
    [SerializeField]
    private GameObject _part4;
    [SerializeField]
    private GameObject _part3;
    [SerializeField]
    private GameObject _part2;
    [SerializeField]
    private GameObject _part1;

    private playerLeft _pl;

    private Rigidbody _boatBody;

    [SerializeField]
    private GameObject _explotionPreab;

    private AudioSource _audioSource;

    private CanvasController _stateRemote;
    private GameManagerController _question;

    public GameObject _gameController, _playerLeft, _canvasController;
    private bool useGravity;

    #endregion


    void Update() {
        QuestionButtonAndCheck();
    }

    private void Start()
    {
        _question = _gameController.GetComponent<GameManagerController>();
        _pl = _playerLeft.GetComponent<playerLeft>();
        _stateRemote = _canvasController.GetComponent<CanvasController>();

        _boatBody = this.gameObject.GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
    }


    #region Instance Methods


    public void QuestionButtonAndCheck()
    {

        if (_stateRemote.GameOn2 == true)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                _stateRemote.GameOn2 = false;
                if (_stateRemote.First2 == true)
                {
                    _stateRemote.First1 = false;
                }

                if (_question.AnswerCurrentQuestionAndCheckIfCorrect(1) == true && _stateRemote.First2 == true)
                {
                    _stateRemote.Done = true;
                    _pl.GetHit();

                }
                else if (_question.AnswerCurrentQuestionAndCheckIfCorrect(1) == true && _stateRemote.Done == false)
                {
                    _pl.GetHit();
                    _stateRemote.Done = true;
                }
            }

            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                _stateRemote.GameOn2 = false;
                if (_stateRemote.First2 == true)
                {
                    _stateRemote.First1 = false;
                }

                if (_question.AnswerCurrentQuestionAndCheckIfCorrect(2) == true && _stateRemote.First2 == true)
                {
                    _stateRemote.Done = true;
                    _pl.GetHit();

                }
                else if (_question.AnswerCurrentQuestionAndCheckIfCorrect(2) == true && _stateRemote.Done == false)
                {
                    _pl.GetHit();
                    _stateRemote.Done = true;
                }
            }

            if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                _stateRemote.GameOn2 = false;
                if (_stateRemote.First2 == true)
                {
                    _stateRemote.First1 = false;
                }

                if (_question.AnswerCurrentQuestionAndCheckIfCorrect(3) == true && _stateRemote.First2 == true)
                {
                    _stateRemote.Done = true;
                    _pl.GetHit();

                }
                else if (_question.AnswerCurrentQuestionAndCheckIfCorrect(3) == true && _stateRemote.Done == false)
                {
                    _pl.GetHit();
                    _stateRemote.Done = true;
                }
            }

           if((Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Keypad1) )&& _stateRemote.First2 == true)
            {
                _question.TimeBetweenQuestions();
            }

        }

    }

    public void GetHit()
    {

        Explotion();

        if (_lives == 7)
        {

            _part7.SetActive(false);
        }
        if (_lives == 6)
        {
            _part6.SetActive(false);
        }
        if (_lives == 5)
        {
            _part5.SetActive(false);
        }
        if (_lives == 4)
        {
            _part4.SetActive(false);
        }
        if (_lives == 3)
        {
            _part3.SetActive(false);
        }
        if (_lives == 2)
        {
            _part2.SetActive(false);
        }
        if (_lives == 1)
        {

            _boatBody.useGravity = true ;

            _question.GameOVER = true;

            _question.EndGame();

        }

        _lives--;

    }

    private void Explotion()
    {
        _audioSource.Play();
        Instantiate(_explotionPreab, transform.position, Quaternion.identity);
    }

    #endregion
}
