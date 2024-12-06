import PySimpleGUI as sg

def create_table1():
    """Create the first table data"""
    return {
        'headings': ['Name', 'Age', 'City'],
        'values': [
            ['Alice', 28, 'New York'],
            ['Bob', 35, 'San Francisco'],
            ['Charlie', 42, 'Chicago']
        ]
    }

def create_table2():
    """Create the second table data"""
    return {
        'headings': ['Product', 'Price', 'Quantity'],
        'values': [
            ['Laptop', 1200, 5],
            ['Phone', 800, 10],
            ['Tablet', 500, 7]
        ]
    }

def create_table3():
    """Create the third table data"""
    return {
        'headings': ['Country', 'Population', 'Continent'],
        'values': [
            ['USA', 331000000, 'North America'],
            ['China', 1439323776, 'Asia'],
            ['Brazil', 212559417, 'South America']
        ]
    }

def main():
    # Initial table data (empty)
    initial_data = {
        'headings': ['Select a table'],
        'values': []
    }

    # Define the layout
    layout = [
        [sg.Text('Select a Table:')],
        [sg.Combo(['Table 1', 'Table 2', 'Table 3'], 
                  default_value='Select a Table',
                  key='-TABLE_SELECTION-', 
                  enable_events=True,
                  size=(20, 1))],
        [sg.Table(values=initial_data['values'], 
                  headings=initial_data['headings'], 
                  auto_size_columns=True,
                  display_row_numbers=False,
                  num_rows=5, 
                  key='-TABLE-',
                  expand_x=True,
                  expand_y=True)],
        [sg.Button('Exit')]
    ]

    # Create the window
    window = sg.Window('Dynamic Table Viewer', layout, finalize=True, size=(400, 200))

    # Event loop
    while True:
        event, values = window.read()
        print(f"Event: {event}")  # Debug print
        print(f"Values: {values}")  # Debug print

        # Handle exit
        if event == sg.WINDOW_CLOSED or event == 'Exit':
            break

        # Handle table selection
        if event == '-TABLE_SELECTION-':
            print("Table selection event triggered")  # Debug print
            
            # Determine which table to display
            selection = values['-TABLE_SELECTION-']
            print(f"Selected: {selection}")  # Debug print
            
            if selection == 'Table 1':
                table_data = create_table1()
            elif selection == 'Table 2':
                table_data = create_table2()
            elif selection == 'Table 3':
                table_data = create_table3()
            else:
                print("Invalid selection")  # Debug print
                continue

            # Update table with new data (only values are updated, headings remain fixed)
            window['-TABLE-'].update(values=table_data['values'])

    # Close the window
    window.close()

if __name__ == '__main__':
    main()