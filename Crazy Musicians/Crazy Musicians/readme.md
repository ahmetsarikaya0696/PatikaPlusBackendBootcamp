# Crazy Musicians API

## Overview

The Crazy Musicians API provides endpoints to manage a list of musicians. Each musician has an ID, full name, job, and a fun feature. The API allows you to perform CRUD operations on the list of musicians.

## Endpoints

### Get All Musicians

**GET** `/api/musicians`

Returns a list of all musicians.

**Response:**
### Get Musician by ID

**GET** `/api/musicians/{id}`

Returns a musician by their ID.

**Response:**
### Search Musicians by Name

**GET** `/api/musicians/search?name={name}`

Searches for musicians by their full name.

**Response:**
### Create a New Musician

**POST** `/api/musicians`

Creates a new musician.

**Request Body:**
**Response:**
- `201 Created` on success.

### Update a Musician

**PUT** `/api/musicians`

Updates an existing musician.

**Request Body:**
**Response:**
- `204 No Content` on success.

### Delete a Musician

**DELETE** `/api/musicians/{id}`

Deletes a musician by their ID.

**Response:**
- `204 No Content` on success.

### Change Musician's Fun Feature

**PATCH** `/api/musicians/change-fun-feature/{id}/{funFeature}`

Changes the fun feature of a musician.

**Response:**
- `204 No Content` on success.

## Models

### Musician
### CreateMusicianRequest
