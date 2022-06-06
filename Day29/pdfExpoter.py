from flat import Client, Flat
import fpdf
import webbrowser



class CreatePDFReport:
    def __init__(self, filename):
        self.filename = filename

    def to_pdf(self, flat):
        pdf = fpdf.FPDF('p','pt','A4')
        pdf.add_page()
        pdf.image("C:/Users/ASUS VIVOBOOK 17/Downloads/home.png",w=50,h=50)

        pdf.set_font(family="Times",size=24,style='B')
        pdf.cell(w=0,h=80,txt="Flatmates Bill",border=0,align='C',ln=1)
        
        pdf.set_font(family="Times",size=18,style='B')
        pdf.cell(w=100,h=40,txt="Period:",border=0)
        pdf.set_font(family="Times",size=18,style='')
        c = 1
        for i in flat.people_in_flat.values():
            if c == 1:
                pdf.cell(w=120,h=40,txt=f"{i['date'].year} - {i['date'].month}",border=0,ln=1)
                pdf.cell(w=0,h=100,txt="",ln=1)
                c = 0
            pdf.cell(w=110,h=40,txt=f"{i['name']}:",border=0)
            pdf.cell(w=110,h=40,txt=f"{i['cost']}",border=0,ln=1)            


        pdf.output(f"{self.filename}.pdf")
        webbrowser.open(f"{self.filename}.pdf")
