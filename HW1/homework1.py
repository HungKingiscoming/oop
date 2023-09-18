class PersonalInformation:
    def __init__(self,name,StudentID,GitHub,Email):
        self.name = name
        self.StudentID = StudentID
        self.GitHub = GitHub
        self.Email = Email

    def show(self):
        print("Personal Information: ",self.name,'\t',self.StudentID,'\t',self.GitHub,'\t',self.Email)


hung = PersonalInformation('Giang Tuan Hung',10122187,'https://github.com/hungiscoming','hungdangden@gmail.com')
hung.show()