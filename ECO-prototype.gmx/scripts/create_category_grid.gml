/*
**  Usage:
**      create_category_grid(filename [,maxx, maxy])
**
**  Arguments:
**      maxx        the max width of the grid, the number of columns, real (optional)
**      maxy        the max height of the grid, number of rows, real (optional)
**      filename    the file from which the grid should be taken
**
**  Returns:
**      an id to the grid
**
**  Notes:
**      Categories will alway be in the first entry of each row
**       the remainder of each row will contain "Entities" or keywords
**       that coorespond to that Category.
**
**  Stewart Cartmell
*/
{
    // variables
    var category_grid, maxx, maxy, xval, yval, wlen, str, file;
    
    // grab passed-in values
    filename = argument0;
    maxx = argument1;
    maxy = argument2;
    if(maxx == 0) maxx = 20;
    if(maxy == 0) maxy = 20;
    
    // create the grid that will act as our dictionary
    category_grid = ds_grid_create(maxx,maxy);

    // set variables
    xval = 0; // current column in the category_grid
    yval = 0; // current row in the category_grid
    wlen = 0; // "word length" or the number of words on the current line
    str = ""; // for now, str is the empty string

    // open the file that holds all of our dictionary terms
    if(is_string(filename)) {
        file = file_text_open_read(filename);
    } else {
        return -1; // no filename return error
    }

    // loop through file
    while (!file_text_eof(file)) {
        // reset str
        str = "";
        // loop through current line
        while (!file_text_eoln(file)) {
            // add a space if past first word in line
            if (wlen > 0) {
                str += " ";   
            }
            // read the string
            str += file_text_read_string(file);
            wlen += 1;
        }
        // reset wlen
        wlen = 0;
    
        // if # symbol, move down to next row
        if (str == "#") {
            yval += 1;
            xval = 0;
        // else, simply add the string & move xval pointer
        } else {
            ds_grid_set(category_grid, xval, yval, str);
            xval += 1;
        }
    
        // move scanning pointer to beginning of next line
        if(!file_text_eof(file)) {
            file_text_readln(file);
        }
    }
    // finally, close the file
    file_text_close(file);

    // return the grid
    return category_grid;
}
