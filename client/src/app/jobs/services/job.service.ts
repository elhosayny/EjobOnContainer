import { Injectable } from '@angular/core';
import { Job } from 'src/app/shared/models/job.model';
import { HttpClient} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class JobService {

  constructor(private httpClient: HttpClient) { }

  add(job:Job){
    return this.httpClient.post('https://localhost:44309/api/v1/job/', job);
  }

  postFile(fileToUpload:File)
  {
    const endpiont = 'https://localhost:5001/api/v1/Jobs/upload';
    const formData:FormData = new FormData();

    formData.append('file',fileToUpload,fileToUpload.name);

    return this.httpClient.post<any>(endpiont,formData,{reportProgress:true,observe:'events'});
  }
  
}
