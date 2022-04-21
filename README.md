# Final-Project-Assignment
ความเป็นมาของโปรเจ็ค
```
มีความชื่นชอบในการเขียนโปรแกรมคำนวณเกรด
```
วัตถุประสงค์ของโปรแกรม
```
อยากพัฒนาโปรแกรม คำนวณเกรดให้ดีขึ้นกว่าปัจจุบัน
```
โครงสร้างของโปรแกรม (Class diagram) ของโปรแกรม
```
classDiagram
  direction LR
  class form1{
  login()
  logout()
  }
  class logout{
  close()
  }
  class form3{
  -number
  -nameMovie
  -day
  -month
  add()
  }
  
  class FileRecordmovie{
  -
  open()
  save()
  }
  class openRecordmovie{
  -location file
  open file()
  }
  class saveRecordmovie{
  -location file
  save file()
  }
  saveRecordmovie --|> FileRecordmovie
  openRecordmovie --|> FileRecordmovie
 
  
  FileRecordmovie --|> form3
  form3 --|> form1
  logout --|> form1
  
``` 







