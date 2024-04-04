import { Photo } from "./Photo"

export type Root = Member[]

export interface Member {
  id: number
  username: string
  photoUrl?: string
  age: number
  knownAs?: string
  created: Date
  lastActive: Date
  gender: any
  introduction?: string
  lookingFor?: string
  interests?: string
  city?: string
  country?: string
  photos: Photo[]
}


