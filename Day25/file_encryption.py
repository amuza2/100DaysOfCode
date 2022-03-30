import PyPDF2

def add_encryption(file_input, file_output):
    pdf_writer = PyPDF2.PdfFileWriter()
    pdf_reader = PyPDF2.PdfFileReader(file_input)

    for page in range(pdf_reader.getNumPages()):
        pdf_writer.addPage(pdf_reader.getPage(page))

    pdf_writer.encrypt(user_pwd="pass123%",owner_pwd=None,use_128bit=True)

    with open(file_output, "wb") as f:
        pdf_writer.write(f)

add_encryption("file_with_watermark.pdf", "secured_file.pdf")