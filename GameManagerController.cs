using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerController : MonoBehaviour {
    
    #region Instance Variables

    private Question[] _questions;
    private int _questionCounter = 0;
    [SerializeField]
    private Text _questionTextField, _answer1TextField, _answer2TextField, _answer3TextField;
    

    public GameObject _canvasController, _playerLeft, _playerRight;


    private CanvasController _stateRemote;

    public bool _gameOver = false;

    private playerLeft _pl;

    private PlayerRight _pr;

    [SerializeField]
    private GameObject _img;

    [SerializeField]
    private GameObject _pnl;

    [SerializeField]
    private GameObject _GamePanel;

    [SerializeField]
    private GameObject _infoTab;

    #endregion


    [SerializeField]
    public Button _Game;
    [SerializeField]
    public Button _Info;
    [SerializeField]
    public Button _GoBackFromInfo;
    [SerializeField]
    public Button _Exit;



    private bool start = true;


    /// <summary>
    /// Start method
    /// </summary>
    private void Start()
    {
        _pl = _playerLeft.GetComponent<playerLeft>();
        _pr = _playerRight.GetComponent<PlayerRight>();
        _stateRemote = _canvasController.GetComponent<CanvasController>();

        _questions = new Question[31];
        InitialiseQuestions();
        SwapQuestions(_questions);
        //PrintToConsole();
        SetQuestionTextFields();

    }
    

    private void Update()
    {
        if (Input.anyKey)
        {
            if (start == true)
            {
                MaintoMenu();
                start = false;
            }
        }



        Button StartGame = _Game.GetComponent<Button>();
        StartGame.onClick.AddListener(MenutoGame);

        Button InfoButton = _Info.GetComponent<Button>();
        InfoButton.onClick.AddListener(MenutoInfo);

        Button GoBack = _GoBackFromInfo.GetComponent<Button>();
        GoBack.onClick.AddListener(InfotoMenu);

        Button ExitGame = _Exit.GetComponent<Button>();
        ExitGame.onClick.AddListener(GoExit);


    }

    private void MaintoMenu()
    {
        _pnl.SetActive(true);
        _img.SetActive(false);
    }

    public void MenutoGame()
    {
        _pnl.SetActive(false);
        _GamePanel.SetActive(true);

        _stateRemote.GameOn1 = true;
        _stateRemote.GameOn2 = true;
    }

    public void MenutoInfo()
    {
        _infoTab.SetActive(true);
        _pnl.SetActive(false);
    }

    public void InfotoMenu()
    {
        _infoTab.SetActive(false);
        _pnl.SetActive(true);
    }

    public void GoExit()
    {
        Application.Quit();
    }

    public void EndGame()
    {
        StartCoroutine("Endgame");
    }


    private IEnumerator  Endgame()
    {
        yield return new WaitForSeconds(4);
        Application.Quit();
    }

    
    public bool GameOVER
    {
        get
        {
            return _gameOver;
        }

        set
        {
            _gameOver = value;
        }
    }

    #region Methods
    /// <summary>  b
    /// Method for creating the questions
    /// </summary>
    private void InitialiseQuestions()
    {
        _questions[0] = new Question("Clothes normally go from a washing  \n machine to what other machine?", "Fax", "Dryer", "ATM", 2);
        _questions[1] = new Question("Which of these animals \n is usually the smallest?", "Goose", "Moose", "Bruce Willis", 1);
        _questions[2] = new Question("Which of these is a \n shade of red?", "Crimson", "Turquoise", "Emerald", 1);
        _questions[3] = new Question("By definition, numbers \n that are less  than zero are classified as what ?", "Imaginary", "Negative", "Transcendental", 2);
        _questions[4] = new Question("What shape best describes \n the USDA's  current diagram of a balanced diet?", "Square", "Pyramid", "Circle", 3);
        _questions[5] = new Question("Which state's capital contains\n  the name of the state ?", "Indiana", "IowaS", "Maine", 1);
        _questions[6] = new Question("Which of these terms refers to\n  the outer region of the sun's atmosphere?", "Tacoma", "Corona", "Zygoma",2);
        _questions[7] = new Question("Which animal is NOT a species of\n  a wild cat?", "Rorqual", "Oncilla", "Margay", 1);
        _questions[8] = new Question("The lead actor in better call saul \n started on what '90s sketch comedy TV series?", "Mr.Show", "The State", "Kids in the Hall", 1);
        _questions[9] = new Question("Which of these would a doctor most \n  likely make use of?", "Clinopinacoid", "Xiphiplastron", "Armmentarium", 3);
        _questions[10] = new Question("A single piece of clothing that covers \n the entire body is called what ?", "Whatsie", "Whosie", "Onesie", 3);
        _questions[11] = new Question("Which of these irons is a common \n heat-styling tool for hair?", "Jeremy", "Curling", "Cast", 2);
        _questions[12] = new Question("What is the name of the first book of \n the Christian Bible?", "The Sorcere's Stone", "Genesis", "Fellowship of the ring", 2);
        _questions[13] = new Question("Which of these terms \n mean common people ?", "Perth Amboy", "Hoi polloi", "bok Choy", 2);
        _questions[14] = new Question("Geographically speaking, an atoll is a type of what ?", "Island", "Peninsula", "Isthmus", 1);
        _questions[15] = new Question("Which of these is a right  \n granted by the Sixth Amendment", "Private trial", "Public trial", "Trial without a jury", 2);
        _questions[16] = new Question("What does the Italian  \n exclamation BASTA! translate to in English ?", "Enough!", "Great !", "Pasta !", 1);
        _questions[17] = new Question("Which US president never \n had a spouse?", "James Buchanan", "Martin Van Buren", "John Tyler", 1);
        _questions[18] = new Question("The swiss Open has twice \n given out which of these to a top tennis player?", "Giant cheese Wheel", "Turf of Swiss grass", "Cow", 3);
        _questions[19] = new Question("Which of these brands  \n does not have a designer contracted for life ?", "Chanel", "Gucci", "Fendi", 2);
        _questions[20] = new Question("According to Japanese tradition,\n  a wedding scheduledon butsumetsu would likely result in what ?", "At least two children", "Cursed marriage", "Financial prosperity", 2);
        _questions[21] = new Question("Which of these actors is known\n  for tweeting pictures of his own paintings?", "Anthony Hopkins", "San Neill", "Michael Caine", 1);
        _questions[22] = new Question("Which of these places is locatedin\n  the tropics ?", "Siberia", "Hawaii", "Antarctica", 2);
        _questions[23] = new Question("What is the name of the layer that\n  lies between the crust and core of the earth?", "Mantle", "Ocean", "Continent", 1);
        _questions[24] = new Question("Which of these is considered \n higher mathematics? ", "Arithmetic", "Area of a square", "Vector calculus", 3);
        _questions[25] = new Question("which of these is not one of \n Switzerland's official languages?", "French", "Italian", "Dutch", 3);
        _questions[26] = new Question("On the periodic table of the elements,\n  what are the horizontal rows called?", "Groups", "Periods", "Blocks", 2);
        _questions[27] = new Question("Which of these college football \n teams famously has the largest stadium?", "Crimson tide", "Wolverines", "Longhorns", 2);
        _questions[28] = new Question("Which of these landmarks supreme Court \n cases was handed down first ?", "Dred Scott v. Sandford", "Brown v. Board", "Plessy v. Ferguson", 1);
        _questions[29] = new Question("The rolling stones song Sympathy for\n  the devil was said to be inspired by what literary work?", "The Master and Margarita", "The Devine Comedy", "Sympathy for the Devil", 1);
        _questions[30] = new Question("Which of there is the title of only \n one book of the Bible?", "Kings", "Chronicles", "Judges", 3);
    }

    /// <summary>
    /// Method for swapping the questions in a random order
    /// </summary>
    /// <param name="questions">The question array to be swapped</param>
    private void SwapQuestions(Question[] questions)
    {
        for (int i = 0; i < questions.Length; i++)
        {
            Question temporary = questions[i];
            int randomNumber = Random.Range(i, questions.Length);
            questions[i] = questions[randomNumber];
            questions[randomNumber] = temporary;
        }
    }
    
    private void SetQuestionTextFields()
    {
        if(_questionTextField != null)
        {
            _questionTextField.text = _questions[_questionCounter].QuestionText;
        }
        if (_answer1TextField != null)
        {
            _answer1TextField.text = _questions[_questionCounter].Answer1Text;
        }
        if (_answer2TextField != null)
        {
            _answer2TextField.text = _questions[_questionCounter].Answer2Text;
        }
        if (_answer3TextField != null)
        {
            _answer3TextField.text = _questions[_questionCounter].Answer3Text;
        }
    }

    /// <summary>
    /// Method for answering the current question and return true / false if the answer was correct or not.
    /// </summary>
    /// <param name="answer">The integer number of the answers</param>
    /// <returns>True if the answer was correct, otherwise false</returns>
    public bool AnswerCurrentQuestionAndCheckIfCorrect(int answer)
    {
        _questions[_questionCounter].setQuestionNumberForAnswer(answer);
        return _questions[_questionCounter].checkIfCorrectAnswer();
    }

    /// <summary>
    /// Setting the next question visible and updating the question counter. 
    /// </summary>
    public void SetNextQuestion()
    {
        if (GameOVER == false)
        {
            if (_questionCounter >= _questions.Length - 1)
            {
                _questionCounter = 0;
            }
            _questionCounter++;
            SetQuestionTextFields();
            _stateRemote.setEverythingBack();
        }
    }

    public void TimeBetweenQuestions()
    {
        StartCoroutine("TimeSpace");
    }


    private IEnumerator TimeSpace()
    {
        yield return new WaitForSeconds(3);
        SetNextQuestion();
    }



    #endregion
}
