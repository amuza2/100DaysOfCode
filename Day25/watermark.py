import PyPDF2

def add_watermark(file_input, file_output, watermark):
    watermark_obj = PyPDF2.PdfFileReader(watermark)
    watermark_page = watermark_obj.getPage(0)

    pdf_reader = PyPDF2.PdfFileReader(file_input)
    pdf_writer = PyPDF2.PdfFileWriter()

    for page in range(pdf_reader.getNumPages()):
        page = pdf_reader.getPage(page)
        page.mergePage(watermark_page)
        pdf_writer.addPage(page)

    with open(file_output, "wb") as f:
        pdf_writer.write(f)

add_watermark("audible_best_sellers.pdf", "file_with_watermark.pdf", "watermark.pdf")