export class StoredFile {
    Name = "";
    Size = 0;
    Type = "";
    Data = "";
    constructor (file : File){
        this.Name = file.name;
        this.Size = file.size;
        this.Type = file.type;
    }
}
