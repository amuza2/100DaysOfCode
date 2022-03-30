import PyPDF2

def pdf_rotation(file_path):
    pdf_writer = PyPDF2.PdfFileWriter()
    pdf_reader = PyPDF2.PdfFileReader(file_path)

    page_1 = pdf_reader.getPage(0).rotateClockwise(90)
    pdf_writer.addPage(page_1)

    page_2 = pdf_reader.getPage(1).rotateClockwise(90)
    pdf_writer.addPage(page_2)

    pdf_writer.addPage(pdf_reader.getPage(2))

    with open("rotatepages.pdf", "wb") as f:
        pdf_writer.write(f)



pdf_rotation("audible_best_sellers.pdf")