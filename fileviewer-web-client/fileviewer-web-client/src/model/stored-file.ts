export class StoredFile {
    name = "";
    size = 0;
    type = "";
    data = "";
    createdAt = Date.now;
    isDeleted = false;
    isViewable = true;
    constructor (file : File){
        this.name = file.name;
        this.size = file.size;
        this.type = file.type;
    }
}
