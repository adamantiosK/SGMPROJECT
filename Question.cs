using UnityEngine;

public class Question{

    #region Instance Variables

    private string _questionText, _answer1Text, _answer2Text, _answer3Text;
    private int _correctAnswer, _chosenAnswer;

    #endregion

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="questionText">The text for the question</param>
    /// <param name="answer1Text">The text for answer 1</param>
    /// <param name="answer2Text">The text for answer 2</param>
    /// <param name="answer3Text">The text for answer 3</param>
    /// <param name="correctAnswer">The integer value of the correct question</param>
    public Question(string questionText, string answer1Text, string answer2Text, string answer3Text, int correctAnswer)
    {
        QuestionText = questionText;
        Answer1Text = answer1Text;
        Answer2Text = answer2Text;
        Answer3Text = answer3Text;
        _correctAnswer = correctAnswer;
    }

    #region Properties

    /// <summary>
    /// Gets and sets the question text
    /// </summary>
    public string QuestionText
    {
        get
        {
            return _questionText;
        }

        set
        {
            _questionText = value;
        }
    }

    /// <summary>
    /// Gets and sets the text for answer 1
    /// </summary>
    public string Answer1Text
    {
        get
        {
            return _answer1Text;
        }

        set
        {
            _answer1Text = value;
        }
    }

    /// <summary>
    /// Gets and sets the text for answer 2
    /// </summary>
    public string Answer2Text
    {
        get
        {
            return _answer2Text;
        }

        set
        {
            _answer2Text = value;
        }
    }

    /// <summary>
    /// Gets and sets the text for answer 3
    /// </summary>
    public string Answer3Text
    {
        get
        {
            return _answer3Text;
        }

        set
        {
            _answer3Text = value;
        }
    }

    #endregion

    #region Methods

    /// <summary>
    /// This method is called whenever a player chooses the answer to the question
    /// </summary>
    /// <param name="number">The integer value of the answer chosen</param>
    public void setQuestionNumberForAnswer(int number)
    {
        _chosenAnswer = number;
    }

    /// <summary>
    /// Method for checking if the chosen answer was the correct one for the question
    /// </summary>
    /// <returns>True if the chosen answer is correct for the specific question</returns>
    public bool checkIfCorrectAnswer()
    {
        return _chosenAnswer == _correctAnswer;
    }

    #endregion
}
