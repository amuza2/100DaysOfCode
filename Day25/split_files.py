import PyPDF2

def split_files(file_path, output_file):
    pdf_reader = PyPDF2.PdfFileReader(file_path)

    for page in range(pdf_reader.getNumPages()):
        pdf_writer = PyPDF2.PdfFileWriter()
        pdf_writer.addPage(pdf_reader.getPage(page))

        file_name = f"{output_file}/file_{page}.pdf"
        with open(file_name, "wb") as f:
            pdf_writer.write(f)


split_files("audible_best_sellers.pdf","./Font")