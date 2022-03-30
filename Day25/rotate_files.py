import PyPDF2

def get_pdf_info(file_path):
    with open(file_path, "rb") as f:
        file = PyPDF2.PdfFileReader(f)
        info = file.getDocumentInfo()
        num_pages = file.getNumPages() 

        text = f"""
            Information {file_path}:

            Author: {info.author}
            Creator: {info.creator}
            Producer: {info.producer}
            Subject: {info.subject}
            Title: {info.title}
            Number of pages: {num_pages}
        """

        print(text)



get_pdf_info("audible_best_sellers.pdf")