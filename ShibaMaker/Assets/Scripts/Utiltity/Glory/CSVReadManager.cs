using System.Collections;

using System.Collections.Generic;

using System.Text.RegularExpressions;

using UnityEngine;

using System.Linq;



[System.Serializable]
public class CSVData
{
    public string name = "";
    public List<string> data = new List<string>();
}



public class CSVReadManager : MonoBehaviour
{
    public List<TextAsset> ListCSVFile = new List<TextAsset>();
    public List<CSVData> ListCsvData = new List<CSVData>();


    public void Start()
    {
        // 나중에 CSVRead 함수 for문 함 더 돌믄 댐.
        CSVRead();
    }



    private void CSVRead()
    {
        string LINE_SPLIT_RE = @"\r\n|\n\r|\n|\r";
        char[] TRIM_CHARS = { '\"' };

        TextAsset data = ListCSVFile[0];        // 임시
        var lines = Regex.Split(data.text, LINE_SPLIT_RE);
        if (lines.Length <= 1) return;

        for (int i = 0; i < lines.Length; i++)
        {
            int count = 0;

            //data를 만들어 주고, 데이터형식의 이름을 지정해준다.

            if (i == 0)
            {
                var name = lines[i].Split(',').ToList(); 
                name.ForEach(csvName =>
                {
                    if (!string.IsNullOrEmpty(csvName))
                    {
                        CSVData csvData = new CSVData();
                        ListCsvData.Add(csvData);
                        ListCsvData[count].name = csvName;
                        count += 1;
                    }
                });
            }
            else           // 같은 방식으로 데이터를 넣어준다.
            {
                count = 0;
                var contents = lines[i].Split(',').ToList();

                contents.ForEach(content =>
                {
                    if (!string.IsNullOrEmpty(content))
                    {
                        ListCsvData[count].data.Add(content);
                        count += 1;
                    }
                });
            }
        }
    }

}