using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text){
        
        _reference = reference;
        List<string> scripture_text = new List<string>(text.Split(' '));

        foreach (string text1 in scripture_text){
            Word word1 = new Word(text1);
            _words.Add(word1);
        }
    }

    public void HideRandomWords(int numberToHide){
        for (int i=0; i <= numberToHide; i++){
            
            var random = new Random();
            int index = random.Next(_words.Count()-1); 
            if(_words[index].IsHidden() == false){
                _words[index].Hide();            
            } else {
                _words[index+1].Hide(); 
            }
        }
        
    }

    public string GetDisplayText(){
        
        string text = "";

        foreach (Word element in _words)
        {
            
            if(element.IsHidden())
            {
                string HiddenText  = "";
                for (int i = 0; i < element.GetDisplayText().Count() ; i++){
                  HiddenText = HiddenText + "_";
                }

                text = $"{text} {HiddenText}";
            } else {
               text = $"{text} {element.GetDisplayText()}";
            }
            
        }

        return $"{_reference.GetDisplayText()} {text.TrimStart()}";
    }

    public bool IsCompletelyHidden(){
        bool IsComplete = true;
        foreach (Word element in _words)
        {            
            if(element.IsHidden() == false)
            {
                IsComplete = false;
            }
        }
        return IsComplete;
    }

}